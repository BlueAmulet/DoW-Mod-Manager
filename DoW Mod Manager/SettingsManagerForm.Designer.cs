﻿namespace DoW_Mod_Manager
{
    partial class SettingsManagerForm
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
            this.settingsLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.defaultsButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.videoTabPage = new System.Windows.Forms.TabPage();
            this.rendererComboBox = new System.Windows.Forms.ComboBox();
            this.rendererLabel = new System.Windows.Forms.Label();
            this.colorDepthComboBox = new System.Windows.Forms.ComboBox();
            this.colorDepthLabel = new System.Windows.Forms.Label();
            this.activeVideocardComboBox = new System.Windows.Forms.ComboBox();
            this.activeVideocardLabel = new System.Windows.Forms.Label();
            this.antialiasingCheckBox = new System.Windows.Forms.CheckBox();
            this.antialiasingLabel = new System.Windows.Forms.Label();
            this.refreshRateComboBox = new System.Windows.Forms.ComboBox();
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.windowedCheckBox = new System.Windows.Forms.CheckBox();
            this.windowedLabel = new System.Windows.Forms.Label();
            this.vSyncCheckBox = new System.Windows.Forms.CheckBox();
            this.vSyncLabel = new System.Windows.Forms.Label();
            this.gammaTrackBar = new System.Windows.Forms.TrackBar();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.screenResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.screenResolutionLabel = new System.Windows.Forms.Label();
            this.audioTabPage = new System.Windows.Forms.TabPage();
            this.networkTabPage = new System.Windows.Forms.TabPage();
            this.textureDetailLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modelDetailLabel = new System.Windows.Forms.Label();
            this.modelDetailComboBox = new System.Windows.Forms.ComboBox();
            this.terrainDetailLabel = new System.Windows.Forms.Label();
            this.terrainDetailComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.videoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.settingsLabel.Location = new System.Drawing.Point(13, 13);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(48, 13);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings:";
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.saveButton.Location = new System.Drawing.Point(16, 534);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 38);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cancelButton.Location = new System.Drawing.Point(436, 534);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 38);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // defaultsButton
            // 
            this.defaultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.defaultsButton.Location = new System.Drawing.Point(224, 534);
            this.defaultsButton.Name = "defaultsButton";
            this.defaultsButton.Size = new System.Drawing.Size(109, 38);
            this.defaultsButton.TabIndex = 3;
            this.defaultsButton.Text = "DEFAULTS";
            this.defaultsButton.UseVisualStyleBackColor = false;
            this.defaultsButton.Click += new System.EventHandler(this.DefaultsButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTabPage);
            this.tabControl1.Controls.Add(this.videoTabPage);
            this.tabControl1.Controls.Add(this.audioTabPage);
            this.tabControl1.Controls.Add(this.networkTabPage);
            this.tabControl1.Location = new System.Drawing.Point(16, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 490);
            this.tabControl1.TabIndex = 5;
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(521, 423);
            this.generalTabPage.TabIndex = 3;
            this.generalTabPage.Text = "General";
            // 
            // videoTabPage
            // 
            this.videoTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.videoTabPage.Controls.Add(this.terrainDetailComboBox);
            this.videoTabPage.Controls.Add(this.terrainDetailLabel);
            this.videoTabPage.Controls.Add(this.modelDetailComboBox);
            this.videoTabPage.Controls.Add(this.modelDetailLabel);
            this.videoTabPage.Controls.Add(this.comboBox1);
            this.videoTabPage.Controls.Add(this.textureDetailLabel);
            this.videoTabPage.Controls.Add(this.rendererComboBox);
            this.videoTabPage.Controls.Add(this.rendererLabel);
            this.videoTabPage.Controls.Add(this.colorDepthComboBox);
            this.videoTabPage.Controls.Add(this.colorDepthLabel);
            this.videoTabPage.Controls.Add(this.activeVideocardComboBox);
            this.videoTabPage.Controls.Add(this.activeVideocardLabel);
            this.videoTabPage.Controls.Add(this.antialiasingCheckBox);
            this.videoTabPage.Controls.Add(this.antialiasingLabel);
            this.videoTabPage.Controls.Add(this.refreshRateComboBox);
            this.videoTabPage.Controls.Add(this.refreshRateLabel);
            this.videoTabPage.Controls.Add(this.windowedCheckBox);
            this.videoTabPage.Controls.Add(this.windowedLabel);
            this.videoTabPage.Controls.Add(this.vSyncCheckBox);
            this.videoTabPage.Controls.Add(this.vSyncLabel);
            this.videoTabPage.Controls.Add(this.gammaTrackBar);
            this.videoTabPage.Controls.Add(this.gammaLabel);
            this.videoTabPage.Controls.Add(this.screenResolutionComboBox);
            this.videoTabPage.Controls.Add(this.screenResolutionLabel);
            this.videoTabPage.Location = new System.Drawing.Point(4, 22);
            this.videoTabPage.Name = "videoTabPage";
            this.videoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.videoTabPage.Size = new System.Drawing.Size(521, 464);
            this.videoTabPage.TabIndex = 0;
            this.videoTabPage.Text = "Video";
            // 
            // rendererComboBox
            // 
            this.rendererComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rendererComboBox.FormattingEnabled = true;
            this.rendererComboBox.Items.AddRange(new object[] {
            "Dx9 : Hardware TnL"});
            this.rendererComboBox.Location = new System.Drawing.Point(113, 55);
            this.rendererComboBox.Name = "rendererComboBox";
            this.rendererComboBox.Size = new System.Drawing.Size(121, 21);
            this.rendererComboBox.TabIndex = 18;
            // 
            // rendererLabel
            // 
            this.rendererLabel.AutoSize = true;
            this.rendererLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rendererLabel.Location = new System.Drawing.Point(10, 58);
            this.rendererLabel.Name = "rendererLabel";
            this.rendererLabel.Size = new System.Drawing.Size(54, 13);
            this.rendererLabel.TabIndex = 17;
            this.rendererLabel.Text = "Renderer:";
            // 
            // colorDepthComboBox
            // 
            this.colorDepthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorDepthComboBox.FormattingEnabled = true;
            this.colorDepthComboBox.Items.AddRange(new object[] {
            "32 bit (TrueColor)",
            "24 bit (HighColor)",
            "16 bit"});
            this.colorDepthComboBox.Location = new System.Drawing.Point(113, 130);
            this.colorDepthComboBox.Name = "colorDepthComboBox";
            this.colorDepthComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorDepthComboBox.TabIndex = 16;
            // 
            // colorDepthLabel
            // 
            this.colorDepthLabel.AutoSize = true;
            this.colorDepthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorDepthLabel.Location = new System.Drawing.Point(10, 133);
            this.colorDepthLabel.Name = "colorDepthLabel";
            this.colorDepthLabel.Size = new System.Drawing.Size(66, 13);
            this.colorDepthLabel.TabIndex = 15;
            this.colorDepthLabel.Text = "Color Depth:";
            // 
            // activeVideocardComboBox
            // 
            this.activeVideocardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeVideocardComboBox.FormattingEnabled = true;
            this.activeVideocardComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.activeVideocardComboBox.Location = new System.Drawing.Point(113, 15);
            this.activeVideocardComboBox.Name = "activeVideocardComboBox";
            this.activeVideocardComboBox.Size = new System.Drawing.Size(121, 21);
            this.activeVideocardComboBox.TabIndex = 14;
            // 
            // activeVideocardLabel
            // 
            this.activeVideocardLabel.AutoSize = true;
            this.activeVideocardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.activeVideocardLabel.Location = new System.Drawing.Point(10, 18);
            this.activeVideocardLabel.Name = "activeVideocardLabel";
            this.activeVideocardLabel.Size = new System.Drawing.Size(91, 13);
            this.activeVideocardLabel.TabIndex = 13;
            this.activeVideocardLabel.Text = "Active Videocard:";
            // 
            // antialiasingCheckBox
            // 
            this.antialiasingCheckBox.AutoSize = true;
            this.antialiasingCheckBox.Location = new System.Drawing.Point(113, 311);
            this.antialiasingCheckBox.Name = "antialiasingCheckBox";
            this.antialiasingCheckBox.Size = new System.Drawing.Size(15, 14);
            this.antialiasingCheckBox.TabIndex = 12;
            this.antialiasingCheckBox.UseVisualStyleBackColor = true;
            // 
            // antialiasingLabel
            // 
            this.antialiasingLabel.AutoSize = true;
            this.antialiasingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.antialiasingLabel.Location = new System.Drawing.Point(10, 311);
            this.antialiasingLabel.Name = "antialiasingLabel";
            this.antialiasingLabel.Size = new System.Drawing.Size(66, 13);
            this.antialiasingLabel.TabIndex = 11;
            this.antialiasingLabel.Text = "Anti-aliasing:";
            // 
            // refreshRateComboBox
            // 
            this.refreshRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refreshRateComboBox.FormattingEnabled = true;
            this.refreshRateComboBox.Items.AddRange(new object[] {
            "144 Hz",
            "120 Hz",
            "90 Hz",
            "85 Hz",
            "75 Hz",
            "60 Hz",
            "59 Hz"});
            this.refreshRateComboBox.Location = new System.Drawing.Point(113, 272);
            this.refreshRateComboBox.Name = "refreshRateComboBox";
            this.refreshRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.refreshRateComboBox.TabIndex = 10;
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.AutoSize = true;
            this.refreshRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.refreshRateLabel.Location = new System.Drawing.Point(10, 275);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(73, 13);
            this.refreshRateLabel.TabIndex = 9;
            this.refreshRateLabel.Text = "Refresh Rate:";
            // 
            // windowedCheckBox
            // 
            this.windowedCheckBox.AutoSize = true;
            this.windowedCheckBox.Location = new System.Drawing.Point(113, 240);
            this.windowedCheckBox.Name = "windowedCheckBox";
            this.windowedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.windowedCheckBox.TabIndex = 8;
            this.windowedCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowedLabel
            // 
            this.windowedLabel.AutoSize = true;
            this.windowedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.windowedLabel.Location = new System.Drawing.Point(10, 240);
            this.windowedLabel.Name = "windowedLabel";
            this.windowedLabel.Size = new System.Drawing.Size(61, 13);
            this.windowedLabel.TabIndex = 7;
            this.windowedLabel.Text = "Windowed:";
            // 
            // vSyncCheckBox
            // 
            this.vSyncCheckBox.AutoSize = true;
            this.vSyncCheckBox.Location = new System.Drawing.Point(113, 207);
            this.vSyncCheckBox.Name = "vSyncCheckBox";
            this.vSyncCheckBox.Size = new System.Drawing.Size(15, 14);
            this.vSyncCheckBox.TabIndex = 6;
            this.vSyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // vSyncLabel
            // 
            this.vSyncLabel.AutoSize = true;
            this.vSyncLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.vSyncLabel.Location = new System.Drawing.Point(10, 208);
            this.vSyncLabel.Name = "vSyncLabel";
            this.vSyncLabel.Size = new System.Drawing.Size(44, 13);
            this.vSyncLabel.TabIndex = 5;
            this.vSyncLabel.Text = "V-Sync:";
            // 
            // gammaTrackBar
            // 
            this.gammaTrackBar.LargeChange = 1;
            this.gammaTrackBar.Location = new System.Drawing.Point(113, 167);
            this.gammaTrackBar.Maximum = 15;
            this.gammaTrackBar.Minimum = 5;
            this.gammaTrackBar.Name = "gammaTrackBar";
            this.gammaTrackBar.Size = new System.Drawing.Size(121, 45);
            this.gammaTrackBar.TabIndex = 4;
            this.gammaTrackBar.Value = 10;
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gammaLabel.Location = new System.Drawing.Point(10, 169);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(46, 13);
            this.gammaLabel.TabIndex = 2;
            this.gammaLabel.Text = "Gamma:";
            // 
            // screenResolutionComboBox
            // 
            this.screenResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenResolutionComboBox.FormattingEnabled = true;
            this.screenResolutionComboBox.Items.AddRange(new object[] {
            "4096×2160",
            "2560×1440",
            "1920×1080",
            "1280×720",
            "1024×768",
            "800×600"});
            this.screenResolutionComboBox.Location = new System.Drawing.Point(113, 93);
            this.screenResolutionComboBox.Name = "screenResolutionComboBox";
            this.screenResolutionComboBox.Size = new System.Drawing.Size(121, 21);
            this.screenResolutionComboBox.TabIndex = 1;
            // 
            // screenResolutionLabel
            // 
            this.screenResolutionLabel.AutoSize = true;
            this.screenResolutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.screenResolutionLabel.Location = new System.Drawing.Point(9, 95);
            this.screenResolutionLabel.Name = "screenResolutionLabel";
            this.screenResolutionLabel.Size = new System.Drawing.Size(97, 13);
            this.screenResolutionLabel.TabIndex = 0;
            this.screenResolutionLabel.Text = "Screen Resolution:";
            // 
            // audioTabPage
            // 
            this.audioTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.audioTabPage.Location = new System.Drawing.Point(4, 22);
            this.audioTabPage.Name = "audioTabPage";
            this.audioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.audioTabPage.Size = new System.Drawing.Size(521, 423);
            this.audioTabPage.TabIndex = 1;
            this.audioTabPage.Text = "Audio";
            // 
            // networkTabPage
            // 
            this.networkTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.networkTabPage.Location = new System.Drawing.Point(4, 22);
            this.networkTabPage.Name = "networkTabPage";
            this.networkTabPage.Size = new System.Drawing.Size(521, 423);
            this.networkTabPage.TabIndex = 2;
            this.networkTabPage.Text = "Network";
            // 
            // textureDetailLabel
            // 
            this.textureDetailLabel.AutoSize = true;
            this.textureDetailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textureDetailLabel.Location = new System.Drawing.Point(10, 349);
            this.textureDetailLabel.Name = "textureDetailLabel";
            this.textureDetailLabel.Size = new System.Drawing.Size(76, 13);
            this.textureDetailLabel.TabIndex = 19;
            this.textureDetailLabel.Text = "Texture Detail:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.comboBox1.Location = new System.Drawing.Point(113, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // modelDetailLabel
            // 
            this.modelDetailLabel.AutoSize = true;
            this.modelDetailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.modelDetailLabel.Location = new System.Drawing.Point(10, 389);
            this.modelDetailLabel.Name = "modelDetailLabel";
            this.modelDetailLabel.Size = new System.Drawing.Size(69, 13);
            this.modelDetailLabel.TabIndex = 21;
            this.modelDetailLabel.Text = "Model Detail:";
            // 
            // modelDetailComboBox
            // 
            this.modelDetailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelDetailComboBox.FormattingEnabled = true;
            this.modelDetailComboBox.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.modelDetailComboBox.Location = new System.Drawing.Point(113, 386);
            this.modelDetailComboBox.Name = "modelDetailComboBox";
            this.modelDetailComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelDetailComboBox.TabIndex = 22;
            // 
            // terrainDetailLabel
            // 
            this.terrainDetailLabel.AutoSize = true;
            this.terrainDetailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.terrainDetailLabel.Location = new System.Drawing.Point(9, 427);
            this.terrainDetailLabel.Name = "terrainDetailLabel";
            this.terrainDetailLabel.Size = new System.Drawing.Size(73, 13);
            this.terrainDetailLabel.TabIndex = 23;
            this.terrainDetailLabel.Text = "Terrain Detail:";
            // 
            // terrainDetailComboBox
            // 
            this.terrainDetailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.terrainDetailComboBox.FormattingEnabled = true;
            this.terrainDetailComboBox.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.terrainDetailComboBox.Location = new System.Drawing.Point(113, 424);
            this.terrainDetailComboBox.Name = "terrainDetailComboBox";
            this.terrainDetailComboBox.Size = new System.Drawing.Size(121, 21);
            this.terrainDetailComboBox.TabIndex = 24;
            // 
            // SettingsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(572, 584);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.defaultsButton);
            this.Controls.Add(this.settingsLabel);
            this.MinimumSize = new System.Drawing.Size(572, 450);
            this.Name = "SettingsManagerForm";
            this.Text = "Settings Manager";
            this.tabControl1.ResumeLayout(false);
            this.videoTabPage.ResumeLayout(false);
            this.videoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button defaultsButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage videoTabPage;
        private System.Windows.Forms.TabPage audioTabPage;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage networkTabPage;
        private System.Windows.Forms.CheckBox antialiasingCheckBox;
        private System.Windows.Forms.Label antialiasingLabel;
        private System.Windows.Forms.ComboBox refreshRateComboBox;
        private System.Windows.Forms.Label refreshRateLabel;
        private System.Windows.Forms.CheckBox windowedCheckBox;
        private System.Windows.Forms.Label windowedLabel;
        private System.Windows.Forms.CheckBox vSyncCheckBox;
        private System.Windows.Forms.Label vSyncLabel;
        private System.Windows.Forms.ComboBox rendererComboBox;
        private System.Windows.Forms.Label rendererLabel;
        private System.Windows.Forms.ComboBox screenResolutionComboBox;
        private System.Windows.Forms.Label screenResolutionLabel;
        private System.Windows.Forms.ComboBox colorDepthComboBox;
        private System.Windows.Forms.Label colorDepthLabel;
        private System.Windows.Forms.TrackBar gammaTrackBar;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.ComboBox activeVideocardComboBox;
        private System.Windows.Forms.Label activeVideocardLabel;
        private System.Windows.Forms.ComboBox modelDetailComboBox;
        private System.Windows.Forms.Label modelDetailLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label textureDetailLabel;
        private System.Windows.Forms.ComboBox terrainDetailComboBox;
        private System.Windows.Forms.Label terrainDetailLabel;
    }
}