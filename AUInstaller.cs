using AmongUsModLauncher.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsModLauncher
{
    public partial class AUInstallerForm : Form
    {
        public const string AppVersion = "v1.2.2";
        private string SteamCommonsPath = @"C:\Program Files (x86)\Steam\steamapps\common\";
        private List<ModModel> mods = new List<ModModel>();
        public AUInstallerForm()
        {
            InitializeComponent();
            CustomInitialize();
        }

        private void CustomInitialize()
        {
            if (ApiHelper.ApiClient == null)
                ApiHelper.InitializeClient();

            txtPath.Text = SteamCommonsPath;
            pnSettings.Dock = DockStyle.Fill;
            cmbVersion.ValueMember = "Tag_name";
            cmbVersion.DisplayMember = "Tag_name";
            ModProcessor.SteamCommPath = SteamCommonsPath;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.pnSettings.Visible = this.pnSettings.Visible ? false : true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            var crtMod = (ModModel)cmbMods.SelectedItem;
            var crtVer = (ModModel)cmbVersion.SelectedItem;
            var ModInstalationPath = $"{SteamCommonsPath}{ModProcessor.ModsFolderName}\\{crtMod.Name}\\{crtVer.Tag_name}\\";
            ProcessStartInfo info = new ProcessStartInfo(ModInstalationPath + "Among Us.exe");
            Process.Start(info);
        }

        private void AUInstaller_Load(object sender, EventArgs e)
        {
            LoadAppVersion();
            LoadCompatibleMods();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = mods;
            cmbMods.DataSource = bindingSource1.DataSource;
            cmbMods.DisplayMember = "Name";
            cmbMods.ValueMember = "Dev_mod";
            var selected = (ModModel)cmbMods.SelectedItem;
            SetSteamPathFromRegistry();
        }


        private void SetSteamPathFromRegistry()
        {
            var installPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Valve\\Steam", false).GetValue("InstallPath");
            if (installPath != null && !installPath.Equals(string.Empty))
                SteamCommonsPath = installPath + "\\steamapps\\common\\";

            this.txtPath.Text = SteamCommonsPath;
        }

        private void LoadCompatibleMods()
        {
            #region read_local_json
            string jsonFromFile;
            using (var reader = new StreamReader("CompatibleMods.json"))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            var modsFromFile = JsonConvert.DeserializeObject<List<ModModel>>(jsonFromFile);
            mods.AddRange(modsFromFile);
            #endregion 
            // Adding Custom mod capability
            //var CustomMod = new ModModel();
            //CustomMod.Name = "Add custom mod";
            //CustomMod.Dev_mod = "Custom";
            //mods.Add(CustomMod);
        }

        Point crtPosOffset = new Point(0, 0);
        private void toolBar_DragEnter(object sender, DragEventArgs e)
        {
            crtPosOffset = AUInstallerForm.MousePosition;
            //this

        }
        private async void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (cmbMods.SelectedIndex < 0)
                MessageBox.Show("Something went wrong while selecting the mod from the ComboBox. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var selectedMod = (ModModel)cmbMods.SelectedItem;
            try
            {
                StartProgressBar();
                await Task.Run(() => GetModReleaseFromGit(selectedMod));
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "There was an error while trying to install the mod.");
            }
        }

        private void StartProgressBar()
        {
            ModProcessor.InstallProgress = 0;
            progressBar1.Visible = true;
            timer1.Start();
        }

        private void cmbMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMod = (ModModel)cmbMods.SelectedItem;
            this.txtDev.Text = selectedMod.Dev_mod;

            ModProcessor.InstalledVersions = GetInstallsForMod(selectedMod.Name);
            ModProcessor.InstalledVersions.Add(new ModModel { Name = selectedMod.Name, Tag_name = "Latest" });
            ModProcessor.InstalledVersions.Reverse();
            cmbVersion.DataSource = ModProcessor.InstalledVersions;
        }

        private List<ModModel> GetInstallsForMod(string name)
        {
            List<ModModel> installs = new List<ModModel>();
            // Check if AULauncher folder exists
            if (!ModProcessor.CheckFolderExists())
                return installs;
            // Check if mod folder exists
            if (!ModProcessor.CheckFolderExists(name))
                return installs;
            // Get installed versions
            installs = ModProcessor.GetInstalledVersions(name);
            return installs;
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedVersion = (ModModel)cmbVersion.SelectedItem;
            var selectedMod = (ModModel)cmbMods.SelectedItem;
            txtModName.Text = $"{selectedMod.Name} - {selectedVersion.Tag_name}";
            if (selectedVersion.Tag_name.ToLower().Equals("latest"))
            {
                //var result = await Task.Run(() => IsLatestInstalled(selectedMod.Dev_mod));
                //if (result)
                //{
                //    Enable(startBtn);
                //}
                //else
                {
                    Enable(downloadBtn);
                    Disable(startBtn);
                    chkAutoStart.Visible = true;
                }
            }
            else
            {
                Disable(downloadBtn);
                Enable(startBtn);
                chkAutoStart.Visible = false;
            }
        }

        private void Disable(Button button)
        {
            button.Visible = false;
            button.Enabled = false;
        }

        private void Enable(Button button)
        {
            button.Visible = true;
            button.Enabled = true;
        }

        private async Task<bool> IsLatestInstalled(string dev_mod)
        {
            return await ModProcessor.IsLatestInstalled(dev_mod);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = ModProcessor.InstallProgress;
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            SteamCommonsPath = txtPath.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetSteamPathFromRegistry();
        }
    }
}
