namespace AmongUsModLauncher
{
    partial class AUInstallerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolBar = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.cmbMods = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkShortcut = new System.Windows.Forms.CheckBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolBar.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolBar.Controls.Add(this.settingsBtn);
            this.toolBar.Controls.Add(this.exitBtn);
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(433, 42);
            this.toolBar.TabIndex = 0;
            this.toolBar.DragEnter += new System.Windows.Forms.DragEventHandler(this.toolBar_DragEnter);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsBtn.BackgroundImage = global::AmongUsModLauncher.Properties.Resources.iconfinder_gear_setting_set_configure_configuration_3643771;
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.settingsBtn.Location = new System.Drawing.Point(3, 3);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(34, 35);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.BackgroundImage = global::AmongUsModLauncher.Properties.Resources.iconfinder_exit_enter_leave_door_in_2931189;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Location = new System.Drawing.Point(397, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 35);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseMnemonic = false;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Visible = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // cmbMods
            // 
            this.cmbMods.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMods.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMods.FormattingEnabled = true;
            this.cmbMods.Location = new System.Drawing.Point(29, 59);
            this.cmbMods.Name = "cmbMods";
            this.cmbMods.Size = new System.Drawing.Size(385, 29);
            this.cmbMods.TabIndex = 17;
            this.cmbMods.SelectedIndexChanged += new System.EventHandler(this.cmbMods_SelectedIndexChanged);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.Window;
            this.startBtn.BackgroundImage = global::AmongUsModLauncher.Properties.Resources.iconfinder_play_video_videos_multimedia_media_3643741;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBtn.Enabled = false;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.startBtn.Location = new System.Drawing.Point(343, 262);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(57, 55);
            this.startBtn.TabIndex = 2;
            this.startBtn.UseMnemonic = false;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Visible = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(62, 258);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(186, 25);
            this.chkAutoStart.TabIndex = 18;
            this.chkAutoStart.Text = "Start game after install";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // chkShortcut
            // 
            this.chkShortcut.AutoSize = true;
            this.chkShortcut.Enabled = false;
            this.chkShortcut.Location = new System.Drawing.Point(62, 291);
            this.chkShortcut.Name = "chkShortcut";
            this.chkShortcut.Size = new System.Drawing.Size(197, 25);
            this.chkShortcut.TabIndex = 19;
            this.chkShortcut.Text = "Add shortcut to Desktop";
            this.chkShortcut.UseVisualStyleBackColor = true;
            this.chkShortcut.Visible = false;
            // 
            // txtModName
            // 
            this.txtModName.BackColor = System.Drawing.SystemColors.Control;
            this.txtModName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModName.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txtModName.Location = new System.Drawing.Point(158, 204);
            this.txtModName.Name = "txtModName";
            this.txtModName.ReadOnly = true;
            this.txtModName.Size = new System.Drawing.Size(256, 22);
            this.txtModName.TabIndex = 21;
            // 
            // txtDev
            // 
            this.txtDev.BackColor = System.Drawing.SystemColors.Control;
            this.txtDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDev.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txtDev.Location = new System.Drawing.Point(158, 153);
            this.txtDev.Name = "txtDev";
            this.txtDev.ReadOnly = true;
            this.txtDev.Size = new System.Drawing.Size(256, 22);
            this.txtDev.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label1.Location = new System.Drawing.Point(25, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Developer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label2.Location = new System.Drawing.Point(25, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mod name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = global::AmongUsModLauncher.Properties.Resources.iconfinder_import_download_save_2931171;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(280, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 53);
            this.button1.TabIndex = 24;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // cmbVersion
            // 
            this.cmbVersion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbVersion.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Location = new System.Drawing.Point(158, 104);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(256, 29);
            this.cmbVersion.TabIndex = 20;
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblVersion.Location = new System.Drawing.Point(25, 107);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(65, 21);
            this.lblVersion.TabIndex = 20;
            this.lblVersion.Text = "Version:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.Location = new System.Drawing.Point(29, 348);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(385, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 28;
            this.progressBar1.Visible = false;
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.SystemColors.Window;
            this.pnSettings.Controls.Add(this.lblInfo);
            this.pnSettings.Controls.Add(this.txtPath);
            this.pnSettings.Controls.Add(this.label3);
            this.pnSettings.Controls.Add(this.lblSettings);
            this.pnSettings.Location = new System.Drawing.Point(420, 63);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(426, 254);
            this.pnSettings.TabIndex = 29;
            this.pnSettings.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(22, 204);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(332, 21);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "* Modify only if you know what you are doing!";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(79, 75);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(335, 21);
            this.txtPath.TabIndex = 23;
            this.txtPath.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "*Path:";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblSettings.Location = new System.Drawing.Point(12, 15);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(117, 37);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Settings";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AUInstallerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(433, 383);
            this.Controls.Add(this.pnSettings);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cmbVersion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.txtDev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkShortcut);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.cmbMods);
            this.Controls.Add(this.toolBar);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AUInstallerForm";
            this.Text = "AUInstaller";
            this.Load += new System.EventHandler(this.AUInstaller_Load);
            this.toolBar.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.ComboBox cmbMods;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkShortcut;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSettings;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}