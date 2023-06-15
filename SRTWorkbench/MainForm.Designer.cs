namespace SRTWorkbench
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl = new TabControl();
            tabPageHome = new TabPage();
            tabPageTranslation = new TabPage();
            tabPageShifter = new TabPage();
            tabPagePartialShifter = new TabPage();
            tabPageEditor = new TabPage();
            tabPageApiSettings = new TabPage();
            btnApiSettingsShowPassword = new Button();
            btnApiSettingsSaveChanges = new Button();
            tbxApiSettingsApiKey = new TextBox();
            lblApiSettingsApiKey = new Label();
            pbxApiSettingsImage = new PictureBox();
            lblApiSettingsTitle = new Label();
            tabPageAbout = new TabPage();
            linkLblAboutProjectUrl = new LinkLabel();
            lblAboutProjectUrlTitle = new Label();
            lblAboutCreator = new Label();
            lblAboutVersion = new Label();
            lblAboutProgramTitle = new Label();
            pbxAboutLogo = new PictureBox();
            lblAboutTitle = new Label();
            tabControl.SuspendLayout();
            tabPageApiSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxApiSettingsImage).BeginInit();
            tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAboutLogo).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageHome);
            tabControl.Controls.Add(tabPageTranslation);
            tabControl.Controls.Add(tabPageShifter);
            tabControl.Controls.Add(tabPagePartialShifter);
            tabControl.Controls.Add(tabPageEditor);
            tabControl.Controls.Add(tabPageApiSettings);
            tabControl.Controls.Add(tabPageAbout);
            tabControl.Location = new Point(11, 10);
            tabControl.Margin = new Padding(2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(762, 540);
            tabControl.TabIndex = 0;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.Gainsboro;
            tabPageHome.Location = new Point(4, 30);
            tabPageHome.Margin = new Padding(2);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(2);
            tabPageHome.Size = new Size(754, 506);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            // 
            // tabPageTranslation
            // 
            tabPageTranslation.BackColor = Color.Gainsboro;
            tabPageTranslation.Location = new Point(4, 24);
            tabPageTranslation.Margin = new Padding(2);
            tabPageTranslation.Name = "tabPageTranslation";
            tabPageTranslation.Padding = new Padding(2);
            tabPageTranslation.Size = new Size(754, 512);
            tabPageTranslation.TabIndex = 1;
            tabPageTranslation.Text = "Translation";
            // 
            // tabPageShifter
            // 
            tabPageShifter.BackColor = Color.Gainsboro;
            tabPageShifter.Location = new Point(4, 24);
            tabPageShifter.Margin = new Padding(3, 4, 3, 4);
            tabPageShifter.Name = "tabPageShifter";
            tabPageShifter.Size = new Size(754, 512);
            tabPageShifter.TabIndex = 2;
            tabPageShifter.Text = "Shifter";
            // 
            // tabPagePartialShifter
            // 
            tabPagePartialShifter.BackColor = Color.Gainsboro;
            tabPagePartialShifter.Location = new Point(4, 24);
            tabPagePartialShifter.Margin = new Padding(3, 4, 3, 4);
            tabPagePartialShifter.Name = "tabPagePartialShifter";
            tabPagePartialShifter.Size = new Size(754, 512);
            tabPagePartialShifter.TabIndex = 3;
            tabPagePartialShifter.Text = "Partial Shifter";
            // 
            // tabPageEditor
            // 
            tabPageEditor.BackColor = Color.Gainsboro;
            tabPageEditor.Location = new Point(4, 24);
            tabPageEditor.Margin = new Padding(3, 4, 3, 4);
            tabPageEditor.Name = "tabPageEditor";
            tabPageEditor.Size = new Size(754, 512);
            tabPageEditor.TabIndex = 4;
            tabPageEditor.Text = "Editor";
            // 
            // tabPageApiSettings
            // 
            tabPageApiSettings.BackColor = Color.Gainsboro;
            tabPageApiSettings.Controls.Add(btnApiSettingsShowPassword);
            tabPageApiSettings.Controls.Add(btnApiSettingsSaveChanges);
            tabPageApiSettings.Controls.Add(tbxApiSettingsApiKey);
            tabPageApiSettings.Controls.Add(lblApiSettingsApiKey);
            tabPageApiSettings.Controls.Add(pbxApiSettingsImage);
            tabPageApiSettings.Controls.Add(lblApiSettingsTitle);
            tabPageApiSettings.Location = new Point(4, 30);
            tabPageApiSettings.Margin = new Padding(3, 4, 3, 4);
            tabPageApiSettings.Name = "tabPageApiSettings";
            tabPageApiSettings.Size = new Size(754, 506);
            tabPageApiSettings.TabIndex = 5;
            tabPageApiSettings.Text = "API Settings";
            // 
            // btnApiSettingsShowPassword
            // 
            btnApiSettingsShowPassword.BackColor = Color.Silver;
            btnApiSettingsShowPassword.BackgroundImage = Properties.Resources.eye_closed;
            btnApiSettingsShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnApiSettingsShowPassword.Cursor = Cursors.Hand;
            btnApiSettingsShowPassword.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnApiSettingsShowPassword.Location = new Point(710, 355);
            btnApiSettingsShowPassword.Name = "btnApiSettingsShowPassword";
            btnApiSettingsShowPassword.Size = new Size(38, 39);
            btnApiSettingsShowPassword.TabIndex = 6;
            btnApiSettingsShowPassword.UseVisualStyleBackColor = false;
            btnApiSettingsShowPassword.Click += btnApiSettingsShowPassword_Click;
            // 
            // btnApiSettingsSaveChanges
            // 
            btnApiSettingsSaveChanges.BackColor = Color.Silver;
            btnApiSettingsSaveChanges.Cursor = Cursors.Hand;
            btnApiSettingsSaveChanges.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnApiSettingsSaveChanges.Location = new Point(217, 419);
            btnApiSettingsSaveChanges.Name = "btnApiSettingsSaveChanges";
            btnApiSettingsSaveChanges.Size = new Size(331, 67);
            btnApiSettingsSaveChanges.TabIndex = 5;
            btnApiSettingsSaveChanges.Text = "Save Changes";
            btnApiSettingsSaveChanges.UseVisualStyleBackColor = false;
            btnApiSettingsSaveChanges.Click += btnApiSettingsSaveChanges_Click;
            // 
            // tbxApiSettingsApiKey
            // 
            tbxApiSettingsApiKey.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbxApiSettingsApiKey.Location = new Point(113, 355);
            tbxApiSettingsApiKey.Name = "tbxApiSettingsApiKey";
            tbxApiSettingsApiKey.Size = new Size(591, 39);
            tbxApiSettingsApiKey.TabIndex = 4;
            tbxApiSettingsApiKey.UseSystemPasswordChar = true;
            // 
            // lblApiSettingsApiKey
            // 
            lblApiSettingsApiKey.AutoSize = true;
            lblApiSettingsApiKey.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblApiSettingsApiKey.Location = new Point(3, 358);
            lblApiSettingsApiKey.Name = "lblApiSettingsApiKey";
            lblApiSettingsApiKey.Size = new Size(104, 32);
            lblApiSettingsApiKey.TabIndex = 3;
            lblApiSettingsApiKey.Text = "API Key:";
            // 
            // pbxApiSettingsImage
            // 
            pbxApiSettingsImage.BackgroundImage = Properties.Resources.deepl;
            pbxApiSettingsImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbxApiSettingsImage.Location = new Point(59, 112);
            pbxApiSettingsImage.Name = "pbxApiSettingsImage";
            pbxApiSettingsImage.Size = new Size(645, 213);
            pbxApiSettingsImage.TabIndex = 2;
            pbxApiSettingsImage.TabStop = false;
            // 
            // lblApiSettingsTitle
            // 
            lblApiSettingsTitle.AutoSize = true;
            lblApiSettingsTitle.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblApiSettingsTitle.Location = new Point(158, 13);
            lblApiSettingsTitle.Name = "lblApiSettingsTitle";
            lblApiSettingsTitle.Size = new Size(426, 86);
            lblApiSettingsTitle.TabIndex = 1;
            lblApiSettingsTitle.Text = "API Settings";
            // 
            // tabPageAbout
            // 
            tabPageAbout.BackColor = Color.Gainsboro;
            tabPageAbout.Controls.Add(linkLblAboutProjectUrl);
            tabPageAbout.Controls.Add(lblAboutProjectUrlTitle);
            tabPageAbout.Controls.Add(lblAboutCreator);
            tabPageAbout.Controls.Add(lblAboutVersion);
            tabPageAbout.Controls.Add(lblAboutProgramTitle);
            tabPageAbout.Controls.Add(pbxAboutLogo);
            tabPageAbout.Controls.Add(lblAboutTitle);
            tabPageAbout.Location = new Point(4, 24);
            tabPageAbout.Margin = new Padding(3, 4, 3, 4);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Size = new Size(754, 512);
            tabPageAbout.TabIndex = 6;
            tabPageAbout.Text = "About";
            // 
            // linkLblAboutProjectUrl
            // 
            linkLblAboutProjectUrl.AutoSize = true;
            linkLblAboutProjectUrl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblAboutProjectUrl.LinkColor = Color.Black;
            linkLblAboutProjectUrl.Location = new Point(186, 401);
            linkLblAboutProjectUrl.Name = "linkLblAboutProjectUrl";
            linkLblAboutProjectUrl.Size = new Size(515, 32);
            linkLblAboutProjectUrl.TabIndex = 6;
            linkLblAboutProjectUrl.TabStop = true;
            linkLblAboutProjectUrl.Text = "https://github.com/aglasencnik/SRTWorkbench";
            linkLblAboutProjectUrl.VisitedLinkColor = Color.DimGray;
            linkLblAboutProjectUrl.LinkClicked += linkLblAboutProjectUrl_LinkClicked;
            // 
            // lblAboutProjectUrlTitle
            // 
            lblAboutProjectUrlTitle.AutoSize = true;
            lblAboutProjectUrlTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutProjectUrlTitle.Location = new Point(48, 401);
            lblAboutProjectUrlTitle.Name = "lblAboutProjectUrlTitle";
            lblAboutProjectUrlTitle.Size = new Size(141, 32);
            lblAboutProjectUrlTitle.TabIndex = 5;
            lblAboutProjectUrlTitle.Text = "Project url:";
            // 
            // lblAboutCreator
            // 
            lblAboutCreator.AutoSize = true;
            lblAboutCreator.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutCreator.Location = new Point(166, 333);
            lblAboutCreator.Name = "lblAboutCreator";
            lblAboutCreator.Size = new Size(414, 40);
            lblAboutCreator.TabIndex = 4;
            lblAboutCreator.Text = "Made by: Amadej Glasenčnik";
            // 
            // lblAboutVersion
            // 
            lblAboutVersion.AutoSize = true;
            lblAboutVersion.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutVersion.Location = new Point(13, 457);
            lblAboutVersion.Name = "lblAboutVersion";
            lblAboutVersion.Size = new Size(202, 40);
            lblAboutVersion.TabIndex = 3;
            lblAboutVersion.Text = "Version: 1.0.0";
            // 
            // lblAboutProgramTitle
            // 
            lblAboutProgramTitle.AutoSize = true;
            lblAboutProgramTitle.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutProgramTitle.Location = new Point(175, 99);
            lblAboutProgramTitle.Name = "lblAboutProgramTitle";
            lblAboutProgramTitle.Size = new Size(373, 65);
            lblAboutProgramTitle.TabIndex = 2;
            lblAboutProgramTitle.Text = "SRT Workbench";
            // 
            // pbxAboutLogo
            // 
            pbxAboutLogo.BackgroundImage = Properties.Resources.SRTWB_logo;
            pbxAboutLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbxAboutLogo.Location = new Point(288, 167);
            pbxAboutLogo.Name = "pbxAboutLogo";
            pbxAboutLogo.Size = new Size(150, 150);
            pbxAboutLogo.TabIndex = 1;
            pbxAboutLogo.TabStop = false;
            // 
            // lblAboutTitle
            // 
            lblAboutTitle.AutoSize = true;
            lblAboutTitle.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutTitle.Location = new Point(109, 13);
            lblAboutTitle.Name = "lblAboutTitle";
            lblAboutTitle.Size = new Size(506, 86);
            lblAboutTitle.TabIndex = 0;
            lblAboutTitle.Text = "About this app";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SRT Workbench";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabPageApiSettings.ResumeLayout(false);
            tabPageApiSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxApiSettingsImage).EndInit();
            tabPageAbout.ResumeLayout(false);
            tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAboutLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageHome;
        private TabPage tabPageTranslation;
        private TabPage tabPageShifter;
        private TabPage tabPagePartialShifter;
        private TabPage tabPageEditor;
        private TabPage tabPageApiSettings;
        private TabPage tabPageAbout;
        private LinkLabel linkLblAboutProjectUrl;
        private Label lblAboutProjectUrlTitle;
        private Label lblAboutCreator;
        private Label lblAboutVersion;
        private Label lblAboutProgramTitle;
        private PictureBox pbxAboutLogo;
        private Label lblAboutTitle;
        private PictureBox pbxApiSettingsImage;
        private Label lblApiSettingsTitle;
        private Button btnApiSettingsSaveChanges;
        private TextBox tbxApiSettingsApiKey;
        private Label lblApiSettingsApiKey;
        private Button btnApiSettingsShowPassword;
    }
}