using AmongUsModLauncher.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsModLauncher
{
    public partial class InstallMods : Form
    {
        //private HttpClient client = new HttpClient();
        public InstallMods()
        {
            InitializeComponent();
            if (ApiHelper.ApiClient == null)
                ApiHelper.InitializeClient();
            txtSteamPath.Text = @"C:\Program Files (x86)\Steam\steamapps\common\";
        }

        private async Task GetModReleaseFromGit(ModModel selectedMod)
        {
            List<ModModel> modReleases;
            try
            {
                // if selected mod has custom version skip loading assets
                ModModel selectedItem = selectedMod;
                ModModel release = selectedItem;
                if (selectedItem.Dev_mod.Equals("Streamblox"))
                {
                    string dev = txtDev.Text;
                    string mod = txtModName.Text;

                    if (dev.Length == 0 || dev.Length == 0)
                    {
                        MessageBox.Show("Please fill in the Developer and Mod name!");
                        return;
                    }
                    selectedItem.Dev_mod = $"{dev}/{mod}";
                }
                if (!selectedItem.Is_custom_version)
                {
                    #region Load_Mod
                    modReleases = await ModProcessor.LoadModReleases(selectedItem.Dev_mod);
                    release = modReleases[0];
                    #endregion Load_Mod
                }

                ModProcessor.Version = release.Tag_name;
                ModProcessor.ModName = release.Name;

                #region DownloadZip_Mod
                var zipData = release.Assets.Count > 0 ? release.Assets[0] : null;
                var fileName = $"{release.Name}#{release.Tag_name}";
                if (zipData == null) throw new Exception("No zip file found!");
                string steamPath = txtSteamPath.Text;
                bool didReqDownload = ModProcessor.DownloadModRelease(zipData.Browser_download_url, fileName, steamPath);
                #endregion DownloadZip_Mod

                if (!didReqDownload)
                    throw new Exception("Error while downloading content");
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMod = (ModModel)cmbMods.SelectedItem;
                await Task.Run(() => GetModReleaseFromGit(selectedMod));
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error while trying to install the mod." +
                    "\n" + ex.Message);
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    txtSteamPath.Text = folderDialog.SelectedPath;
            }
            txtSteamPath.Text += "\\";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var isVisible = pnSettings.Visible;
            pnSettings.Visible = !isVisible;
        }

        private List<ModModel> mods = new List<ModModel>();
        private void AddCustomMod_Load(object sender, EventArgs e)
        {
            LoadCompatibleMods();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = mods;
            cmbMods.DataSource = bindingSource1.DataSource;
            cmbMods.DisplayMember = "Name";
            cmbMods.ValueMember = "Dev_mod";
            var selected = (ModModel)cmbMods.SelectedItem;
            cmbMods_SelectionChangeComitted(null,null);
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
            var CustomMod = new ModModel();
            CustomMod.Name = "Add custom mod";
            CustomMod.Dev_mod = "Streamblox";
            mods.Add(CustomMod);
        }

        private void cmbMods_SelectionChangeComitted(object sender, EventArgs e)
        {
            var selectedMod = (ModModel)cmbMods.SelectedItem;
            if (selectedMod.Dev_mod.Equals("Streamblox"))
            {
                pnCustom.Visible = true;
                grbModInfo.Visible = false;
            }
            else
            {
                pnCustom.Visible = false;
                grbModInfo.Visible = true;
            }
            txtDescription.Text = selectedMod.Body;
            grbModInfo.Text = selectedMod.Name;
        }
    }
}
