
namespace AmongUsModLauncher
{
    partial class InstallMods
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
            this.txtDev = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSteamPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnCustom = new System.Windows.Forms.Panel();
            this.cmbMods = new System.Windows.Forms.ComboBox();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grbModInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pbModBanner = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnCustom.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbModInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModBanner)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDev
            // 
            this.txtDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDev.Location = new System.Drawing.Point(21, 31);
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(293, 26);
            this.txtDev.TabIndex = 3;
            // 
            // txtModName
            // 
            this.txtModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModName.Location = new System.Drawing.Point(25, 93);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(289, 26);
            this.txtModName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Developer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mod name";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(280, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Mod";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSteamPath
            // 
            this.txtSteamPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamPath.Location = new System.Drawing.Point(18, 38);
            this.txtSteamPath.Name = "txtSteamPath";
            this.txtSteamPath.Size = new System.Drawing.Size(388, 26);
            this.txtSteamPath.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Steam folder (only modify if you know it\'s wrong)";
            // 
            // pnCustom
            // 
            this.pnCustom.Controls.Add(this.txtModName);
            this.pnCustom.Controls.Add(this.txtDev);
            this.pnCustom.Controls.Add(this.label1);
            this.pnCustom.Controls.Add(this.label2);
            this.pnCustom.Location = new System.Drawing.Point(3, 524);
            this.pnCustom.Name = "pnCustom";
            this.pnCustom.Size = new System.Drawing.Size(417, 141);
            this.pnCustom.TabIndex = 15;
            // 
            // cmbMods
            // 
            this.cmbMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMods.FormattingEnabled = true;
            this.cmbMods.Location = new System.Drawing.Point(15, 19);
            this.cmbMods.Name = "cmbMods";
            this.cmbMods.Size = new System.Drawing.Size(256, 28);
            this.cmbMods.TabIndex = 16;
            this.cmbMods.SelectionChangeCommitted += new System.EventHandler(this.cmbMods_SelectionChangeComitted);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.label3);
            this.pnSettings.Controls.Add(this.btnChangePath);
            this.pnSettings.Controls.Add(this.label4);
            this.pnSettings.Controls.Add(this.txtSteamPath);
            this.pnSettings.Location = new System.Drawing.Point(3, 3);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(417, 175);
            this.pnSettings.TabIndex = 17;
            this.pnSettings.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Note: if you select a path that doesn\'t contain the Steam directory,\r\n your mod w" +
    "ill be downloaded, but not installed";
            // 
            // btnChangePath
            // 
            this.btnChangePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnChangePath.Location = new System.Drawing.Point(313, 86);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(93, 28);
            this.btnChangePath.TabIndex = 18;
            this.btnChangePath.Text = "Change";
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::AmongUsModLauncher.Properties.Resources.iconfinder_Gear_4200781;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(12, 23);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(50, 50);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnSettings);
            this.flowLayoutPanel1.Controls.Add(this.grbModInfo);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.pnCustom);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 535);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // grbModInfo
            // 
            this.grbModInfo.Controls.Add(this.txtDescription);
            this.grbModInfo.Controls.Add(this.pbModBanner);
            this.grbModInfo.Location = new System.Drawing.Point(3, 184);
            this.grbModInfo.Name = "grbModInfo";
            this.grbModInfo.Size = new System.Drawing.Size(420, 273);
            this.grbModInfo.TabIndex = 1;
            this.grbModInfo.TabStop = false;
            this.grbModInfo.Text = "groupBox1";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 107);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(390, 154);
            this.txtDescription.TabIndex = 0;
            // 
            // pbModBanner
            // 
            this.pbModBanner.Location = new System.Drawing.Point(10, 19);
            this.pbModBanner.Name = "pbModBanner";
            this.pbModBanner.Size = new System.Drawing.Size(390, 80);
            this.pbModBanner.TabIndex = 2;
            this.pbModBanner.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMods);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(3, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 55);
            this.panel1.TabIndex = 20;
            // 
            // InstallMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 578);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSettings);
            this.Name = "InstallMods";
            this.Text = "Among Us Mod installer - Beta version";
            this.Load += new System.EventHandler(this.AddCustomMod_Load);
            this.pnCustom.ResumeLayout(false);
            this.pnCustom.PerformLayout();
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grbModInfo.ResumeLayout(false);
            this.grbModInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModBanner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSteamPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnCustom;
        private System.Windows.Forms.ComboBox cmbMods;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pbModBanner;
        private System.Windows.Forms.GroupBox grbModInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel1;
    }
}