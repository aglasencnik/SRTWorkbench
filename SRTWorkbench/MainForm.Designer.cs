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
            tabPageAbout = new TabPage();
            linkLblAboutProjectUrl = new LinkLabel();
            lblAboutProjectUrlTitle = new Label();
            lblAboutCreator = new Label();
            lblAboutVersion = new Label();
            lblAboutProgramTitle = new Label();
            pbxAboutLogo = new PictureBox();
            lblAboutTitle = new Label();
            tabControl.SuspendLayout();
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
            tabControl.Size = new Size(986, 707);
            tabControl.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.Gainsboro;
            tabPageHome.Location = new Point(4, 30);
            tabPageHome.Margin = new Padding(2);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(2);
            tabPageHome.Size = new Size(978, 673);
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
            tabPageTranslation.Size = new Size(978, 679);
            tabPageTranslation.TabIndex = 1;
            tabPageTranslation.Text = "Translation";
            // 
            // tabPageShifter
            // 
            tabPageShifter.BackColor = Color.Gainsboro;
            tabPageShifter.Location = new Point(4, 24);
            tabPageShifter.Margin = new Padding(3, 4, 3, 4);
            tabPageShifter.Name = "tabPageShifter";
            tabPageShifter.Size = new Size(978, 679);
            tabPageShifter.TabIndex = 2;
            tabPageShifter.Text = "Shifter";
            // 
            // tabPagePartialShifter
            // 
            tabPagePartialShifter.BackColor = Color.Gainsboro;
            tabPagePartialShifter.Location = new Point(4, 24);
            tabPagePartialShifter.Margin = new Padding(3, 4, 3, 4);
            tabPagePartialShifter.Name = "tabPagePartialShifter";
            tabPagePartialShifter.Size = new Size(978, 679);
            tabPagePartialShifter.TabIndex = 3;
            tabPagePartialShifter.Text = "Partial Shifter";
            // 
            // tabPageEditor
            // 
            tabPageEditor.BackColor = Color.Gainsboro;
            tabPageEditor.Location = new Point(4, 24);
            tabPageEditor.Margin = new Padding(3, 4, 3, 4);
            tabPageEditor.Name = "tabPageEditor";
            tabPageEditor.Size = new Size(978, 679);
            tabPageEditor.TabIndex = 4;
            tabPageEditor.Text = "Editor";
            // 
            // tabPageApiSettings
            // 
            tabPageApiSettings.BackColor = Color.Gainsboro;
            tabPageApiSettings.Location = new Point(4, 24);
            tabPageApiSettings.Margin = new Padding(3, 4, 3, 4);
            tabPageApiSettings.Name = "tabPageApiSettings";
            tabPageApiSettings.Size = new Size(978, 679);
            tabPageApiSettings.TabIndex = 5;
            tabPageApiSettings.Text = "API Settings";
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
            tabPageAbout.Location = new Point(4, 30);
            tabPageAbout.Margin = new Padding(3, 4, 3, 4);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Size = new Size(978, 673);
            tabPageAbout.TabIndex = 6;
            tabPageAbout.Text = "About";
            // 
            // linkLblAboutProjectUrl
            // 
            linkLblAboutProjectUrl.AutoSize = true;
            linkLblAboutProjectUrl.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblAboutProjectUrl.LinkColor = Color.Black;
            linkLblAboutProjectUrl.Location = new Point(269, 447);
            linkLblAboutProjectUrl.Name = "linkLblAboutProjectUrl";
            linkLblAboutProjectUrl.Size = new Size(614, 40);
            linkLblAboutProjectUrl.TabIndex = 6;
            linkLblAboutProjectUrl.TabStop = true;
            linkLblAboutProjectUrl.Text = "https://github.com/aglasencnik/SRTWorkbench";
            linkLblAboutProjectUrl.VisitedLinkColor = Color.DimGray;
            linkLblAboutProjectUrl.LinkClicked += linkLblAboutProjectUrl_LinkClicked;
            // 
            // lblAboutProjectUrlTitle
            // 
            lblAboutProjectUrlTitle.AutoSize = true;
            lblAboutProjectUrlTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutProjectUrlTitle.Location = new Point(105, 447);
            lblAboutProjectUrlTitle.Name = "lblAboutProjectUrlTitle";
            lblAboutProjectUrlTitle.Size = new Size(168, 40);
            lblAboutProjectUrlTitle.TabIndex = 5;
            lblAboutProjectUrlTitle.Text = "Project url:";
            // 
            // lblAboutCreator
            // 
            lblAboutCreator.AutoSize = true;
            lblAboutCreator.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutCreator.Location = new Point(288, 376);
            lblAboutCreator.Name = "lblAboutCreator";
            lblAboutCreator.Size = new Size(414, 40);
            lblAboutCreator.TabIndex = 4;
            lblAboutCreator.Text = "Made by: Amadej Glasenčnik";
            // 
            // lblAboutVersion
            // 
            lblAboutVersion.AutoSize = true;
            lblAboutVersion.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutVersion.Location = new Point(13, 622);
            lblAboutVersion.Name = "lblAboutVersion";
            lblAboutVersion.Size = new Size(202, 40);
            lblAboutVersion.TabIndex = 3;
            lblAboutVersion.Text = "Version: 1.0.0";
            // 
            // lblAboutProgramTitle
            // 
            lblAboutProgramTitle.AutoSize = true;
            lblAboutProgramTitle.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutProgramTitle.Location = new Point(302, 133);
            lblAboutProgramTitle.Name = "lblAboutProgramTitle";
            lblAboutProgramTitle.Size = new Size(373, 65);
            lblAboutProgramTitle.TabIndex = 2;
            lblAboutProgramTitle.Text = "SRT Workbench";
            // 
            // pbxAboutLogo
            // 
            pbxAboutLogo.BackgroundImage = Properties.Resources.SRTWB_logo;
            pbxAboutLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbxAboutLogo.Location = new Point(415, 201);
            pbxAboutLogo.Name = "pbxAboutLogo";
            pbxAboutLogo.Size = new Size(150, 150);
            pbxAboutLogo.TabIndex = 1;
            pbxAboutLogo.TabStop = false;
            // 
            // lblAboutTitle
            // 
            lblAboutTitle.AutoSize = true;
            lblAboutTitle.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutTitle.Location = new Point(238, 27);
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
            ClientSize = new Size(1008, 729);
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
    }
}