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
            lblShifterExplainText = new Label();
            numericUpDownShifter = new NumericUpDown();
            btnShifter = new Button();
            lblShifterShiftText = new Label();
            btnShifterOpenFile = new Button();
            lblShifterTitle = new Label();
            tabPagePartialShifter = new TabPage();
            label1 = new Label();
            partialShifterPanel = new FlowLayoutPanel();
            btnPartialShifter = new Button();
            btnPartialShifterOpenFile = new Button();
            lblPartialShifterTitle = new Label();
            tabPageEditor = new TabPage();
            lblEditorOrText = new Label();
            lblEditorCtrlSText = new Label();
            btnEditorNext = new Button();
            btnEditorPrevious = new Button();
            btnEditorFind = new Button();
            numericUpDownEditorId = new NumericUpDown();
            lblEditorSearchText = new Label();
            btnEditorSaveFile = new Button();
            btnEditorOpenFile = new Button();
            lblEditorTitle = new Label();
            rtbxEditor = new RichTextBox();
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
            tabPageShifter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShifter).BeginInit();
            tabPagePartialShifter.SuspendLayout();
            tabPageEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditorId).BeginInit();
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
            tabControl.Margin = new Padding(0);
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
            tabPageHome.Margin = new Padding(0);
            tabPageHome.Name = "tabPageHome";
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
            tabPageShifter.Controls.Add(lblShifterExplainText);
            tabPageShifter.Controls.Add(numericUpDownShifter);
            tabPageShifter.Controls.Add(btnShifter);
            tabPageShifter.Controls.Add(lblShifterShiftText);
            tabPageShifter.Controls.Add(btnShifterOpenFile);
            tabPageShifter.Controls.Add(lblShifterTitle);
            tabPageShifter.Location = new Point(4, 24);
            tabPageShifter.Margin = new Padding(3, 4, 3, 4);
            tabPageShifter.Name = "tabPageShifter";
            tabPageShifter.Size = new Size(754, 512);
            tabPageShifter.TabIndex = 2;
            tabPageShifter.Text = "Shifter";
            // 
            // lblShifterExplainText
            // 
            lblShifterExplainText.AutoSize = true;
            lblShifterExplainText.BackColor = Color.Transparent;
            lblShifterExplainText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblShifterExplainText.Location = new Point(35, 289);
            lblShifterExplainText.Name = "lblShifterExplainText";
            lblShifterExplainText.Size = new Size(259, 25);
            lblShifterExplainText.TabIndex = 11;
            lblShifterExplainText.Text = "1 second = 1000 milliseconds";
            // 
            // numericUpDownShifter
            // 
            numericUpDownShifter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownShifter.Location = new Point(329, 242);
            numericUpDownShifter.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownShifter.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDownShifter.Name = "numericUpDownShifter";
            numericUpDownShifter.Size = new Size(149, 39);
            numericUpDownShifter.TabIndex = 10;
            // 
            // btnShifter
            // 
            btnShifter.BackColor = Color.Silver;
            btnShifter.Cursor = Cursors.Hand;
            btnShifter.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnShifter.Location = new Point(275, 348);
            btnShifter.Name = "btnShifter";
            btnShifter.Size = new Size(203, 72);
            btnShifter.TabIndex = 9;
            btnShifter.Text = "Shift";
            btnShifter.UseVisualStyleBackColor = false;
            btnShifter.Click += btnShifter_Click;
            // 
            // lblShifterShiftText
            // 
            lblShifterShiftText.AutoSize = true;
            lblShifterShiftText.BackColor = Color.Transparent;
            lblShifterShiftText.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblShifterShiftText.Location = new Point(35, 240);
            lblShifterShiftText.Name = "lblShifterShiftText";
            lblShifterShiftText.Size = new Size(288, 37);
            lblShifterShiftText.TabIndex = 8;
            lblShifterShiftText.Text = "Shift (in milliseconds):";
            // 
            // btnShifterOpenFile
            // 
            btnShifterOpenFile.BackColor = Color.Silver;
            btnShifterOpenFile.Cursor = Cursors.Hand;
            btnShifterOpenFile.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnShifterOpenFile.Location = new Point(35, 132);
            btnShifterOpenFile.Name = "btnShifterOpenFile";
            btnShifterOpenFile.Size = new Size(203, 72);
            btnShifterOpenFile.TabIndex = 7;
            btnShifterOpenFile.Text = "Open File";
            btnShifterOpenFile.UseVisualStyleBackColor = false;
            btnShifterOpenFile.Click += btnShifterOpenFile_Click;
            // 
            // lblShifterTitle
            // 
            lblShifterTitle.AutoSize = true;
            lblShifterTitle.BackColor = Color.Transparent;
            lblShifterTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblShifterTitle.Location = new Point(229, 37);
            lblShifterTitle.Name = "lblShifterTitle";
            lblShifterTitle.Size = new Size(286, 50);
            lblShifterTitle.TabIndex = 3;
            lblShifterTitle.Text = "Subtitle Shifter";
            // 
            // tabPagePartialShifter
            // 
            tabPagePartialShifter.BackColor = Color.Gainsboro;
            tabPagePartialShifter.Controls.Add(label1);
            tabPagePartialShifter.Controls.Add(partialShifterPanel);
            tabPagePartialShifter.Controls.Add(btnPartialShifter);
            tabPagePartialShifter.Controls.Add(btnPartialShifterOpenFile);
            tabPagePartialShifter.Controls.Add(lblPartialShifterTitle);
            tabPagePartialShifter.Location = new Point(4, 30);
            tabPagePartialShifter.Margin = new Padding(0, 5, 0, 5);
            tabPagePartialShifter.Name = "tabPagePartialShifter";
            tabPagePartialShifter.Size = new Size(754, 506);
            tabPagePartialShifter.TabIndex = 3;
            tabPagePartialShifter.Text = "Partial Shifter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 265);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 12;
            label1.Text = "1 second = 1000 milliseconds";
            // 
            // partialShifterPanel
            // 
            partialShifterPanel.AutoScroll = true;
            partialShifterPanel.BorderStyle = BorderStyle.FixedSingle;
            partialShifterPanel.Location = new Point(272, 75);
            partialShifterPanel.Margin = new Padding(0, 3, 0, 3);
            partialShifterPanel.Name = "partialShifterPanel";
            partialShifterPanel.Size = new Size(475, 400);
            partialShifterPanel.TabIndex = 11;
            // 
            // btnPartialShifter
            // 
            btnPartialShifter.BackColor = Color.Silver;
            btnPartialShifter.Cursor = Cursors.Hand;
            btnPartialShifter.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPartialShifter.Location = new Point(33, 403);
            btnPartialShifter.Name = "btnPartialShifter";
            btnPartialShifter.Size = new Size(203, 72);
            btnPartialShifter.TabIndex = 10;
            btnPartialShifter.Text = "Shift";
            btnPartialShifter.UseVisualStyleBackColor = false;
            btnPartialShifter.Click += btnPartialShifter_Click;
            // 
            // btnPartialShifterOpenFile
            // 
            btnPartialShifterOpenFile.BackColor = Color.Silver;
            btnPartialShifterOpenFile.Cursor = Cursors.Hand;
            btnPartialShifterOpenFile.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPartialShifterOpenFile.Location = new Point(33, 75);
            btnPartialShifterOpenFile.Name = "btnPartialShifterOpenFile";
            btnPartialShifterOpenFile.Size = new Size(203, 72);
            btnPartialShifterOpenFile.TabIndex = 8;
            btnPartialShifterOpenFile.Text = "Open File";
            btnPartialShifterOpenFile.UseVisualStyleBackColor = false;
            btnPartialShifterOpenFile.Click += btnPartialShifterOpenFile_Click;
            // 
            // lblPartialShifterTitle
            // 
            lblPartialShifterTitle.AutoSize = true;
            lblPartialShifterTitle.BackColor = Color.Transparent;
            lblPartialShifterTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartialShifterTitle.Location = new Point(171, 12);
            lblPartialShifterTitle.Name = "lblPartialShifterTitle";
            lblPartialShifterTitle.Size = new Size(410, 50);
            lblPartialShifterTitle.TabIndex = 4;
            lblPartialShifterTitle.Text = "Partial Subtitle Shifter";
            // 
            // tabPageEditor
            // 
            tabPageEditor.BackColor = Color.Gainsboro;
            tabPageEditor.Controls.Add(lblEditorOrText);
            tabPageEditor.Controls.Add(lblEditorCtrlSText);
            tabPageEditor.Controls.Add(btnEditorNext);
            tabPageEditor.Controls.Add(btnEditorPrevious);
            tabPageEditor.Controls.Add(btnEditorFind);
            tabPageEditor.Controls.Add(numericUpDownEditorId);
            tabPageEditor.Controls.Add(lblEditorSearchText);
            tabPageEditor.Controls.Add(btnEditorSaveFile);
            tabPageEditor.Controls.Add(btnEditorOpenFile);
            tabPageEditor.Controls.Add(lblEditorTitle);
            tabPageEditor.Controls.Add(rtbxEditor);
            tabPageEditor.Location = new Point(4, 24);
            tabPageEditor.Margin = new Padding(3, 4, 3, 4);
            tabPageEditor.Name = "tabPageEditor";
            tabPageEditor.Size = new Size(754, 512);
            tabPageEditor.TabIndex = 4;
            tabPageEditor.Text = "Editor";
            // 
            // lblEditorOrText
            // 
            lblEditorOrText.AutoSize = true;
            lblEditorOrText.BackColor = Color.Transparent;
            lblEditorOrText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditorOrText.Location = new Point(659, 443);
            lblEditorOrText.Name = "lblEditorOrText";
            lblEditorOrText.Size = new Size(42, 30);
            lblEditorOrText.TabIndex = 14;
            lblEditorOrText.Text = "OR";
            // 
            // lblEditorCtrlSText
            // 
            lblEditorCtrlSText.AutoSize = true;
            lblEditorCtrlSText.BackColor = Color.Transparent;
            lblEditorCtrlSText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditorCtrlSText.Location = new Point(644, 473);
            lblEditorCtrlSText.Name = "lblEditorCtrlSText";
            lblEditorCtrlSText.Size = new Size(73, 30);
            lblEditorCtrlSText.TabIndex = 13;
            lblEditorCtrlSText.Text = "Ctrl+S";
            // 
            // btnEditorNext
            // 
            btnEditorNext.BackColor = Color.Silver;
            btnEditorNext.Cursor = Cursors.Hand;
            btnEditorNext.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditorNext.Location = new Point(682, 287);
            btnEditorNext.Name = "btnEditorNext";
            btnEditorNext.Size = new Size(61, 51);
            btnEditorNext.TabIndex = 12;
            btnEditorNext.Text = ">";
            btnEditorNext.UseVisualStyleBackColor = false;
            btnEditorNext.Click += btnEditorNext_Click;
            // 
            // btnEditorPrevious
            // 
            btnEditorPrevious.BackColor = Color.Silver;
            btnEditorPrevious.Cursor = Cursors.Hand;
            btnEditorPrevious.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditorPrevious.Location = new Point(621, 287);
            btnEditorPrevious.Name = "btnEditorPrevious";
            btnEditorPrevious.Size = new Size(61, 51);
            btnEditorPrevious.TabIndex = 11;
            btnEditorPrevious.Text = "<";
            btnEditorPrevious.UseVisualStyleBackColor = false;
            btnEditorPrevious.Click += btnEditorPrevious_Click;
            // 
            // btnEditorFind
            // 
            btnEditorFind.BackColor = Color.Silver;
            btnEditorFind.Cursor = Cursors.Hand;
            btnEditorFind.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditorFind.Location = new Point(621, 230);
            btnEditorFind.Name = "btnEditorFind";
            btnEditorFind.Size = new Size(122, 51);
            btnEditorFind.TabIndex = 10;
            btnEditorFind.Text = "Find";
            btnEditorFind.UseVisualStyleBackColor = false;
            btnEditorFind.Click += btnEditorFind_Click;
            // 
            // numericUpDownEditorId
            // 
            numericUpDownEditorId.Location = new Point(621, 185);
            numericUpDownEditorId.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownEditorId.Name = "numericUpDownEditorId";
            numericUpDownEditorId.Size = new Size(120, 29);
            numericUpDownEditorId.TabIndex = 9;
            // 
            // lblEditorSearchText
            // 
            lblEditorSearchText.AutoSize = true;
            lblEditorSearchText.BackColor = Color.Transparent;
            lblEditorSearchText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditorSearchText.Location = new Point(615, 152);
            lblEditorSearchText.Name = "lblEditorSearchText";
            lblEditorSearchText.Size = new Size(136, 30);
            lblEditorSearchText.TabIndex = 8;
            lblEditorSearchText.Text = "Search by Id:";
            // 
            // btnEditorSaveFile
            // 
            btnEditorSaveFile.BackColor = Color.Silver;
            btnEditorSaveFile.Cursor = Cursors.Hand;
            btnEditorSaveFile.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditorSaveFile.Location = new Point(621, 389);
            btnEditorSaveFile.Name = "btnEditorSaveFile";
            btnEditorSaveFile.Size = new Size(122, 51);
            btnEditorSaveFile.TabIndex = 7;
            btnEditorSaveFile.Text = "Save File";
            btnEditorSaveFile.UseVisualStyleBackColor = false;
            btnEditorSaveFile.Click += btnEditorSaveFile_Click;
            // 
            // btnEditorOpenFile
            // 
            btnEditorOpenFile.BackColor = Color.Silver;
            btnEditorOpenFile.Cursor = Cursors.Hand;
            btnEditorOpenFile.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditorOpenFile.Location = new Point(621, 53);
            btnEditorOpenFile.Name = "btnEditorOpenFile";
            btnEditorOpenFile.Size = new Size(122, 51);
            btnEditorOpenFile.TabIndex = 6;
            btnEditorOpenFile.Text = "Open File";
            btnEditorOpenFile.UseVisualStyleBackColor = false;
            btnEditorOpenFile.Click += btnEditorOpenFile_Click;
            // 
            // lblEditorTitle
            // 
            lblEditorTitle.AutoSize = true;
            lblEditorTitle.BackColor = Color.Transparent;
            lblEditorTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditorTitle.Location = new Point(316, 0);
            lblEditorTitle.Name = "lblEditorTitle";
            lblEditorTitle.Size = new Size(128, 50);
            lblEditorTitle.TabIndex = 2;
            lblEditorTitle.Text = "Editor";
            // 
            // rtbxEditor
            // 
            rtbxEditor.Location = new Point(3, 53);
            rtbxEditor.Name = "rtbxEditor";
            rtbxEditor.Size = new Size(612, 450);
            rtbxEditor.TabIndex = 0;
            rtbxEditor.Text = "";
            rtbxEditor.KeyDown += rtbxEditor_KeyDown;
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
            tabPageApiSettings.Location = new Point(4, 24);
            tabPageApiSettings.Margin = new Padding(3, 4, 3, 4);
            tabPageApiSettings.Name = "tabPageApiSettings";
            tabPageApiSettings.Size = new Size(754, 512);
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
            tabPageShifter.ResumeLayout(false);
            tabPageShifter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShifter).EndInit();
            tabPagePartialShifter.ResumeLayout(false);
            tabPagePartialShifter.PerformLayout();
            tabPageEditor.ResumeLayout(false);
            tabPageEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditorId).EndInit();
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
        private RichTextBox rtbxEditor;
        private Button btnEditorOpenFile;
        private Label lblEditorTitle;
        private Button btnEditorSaveFile;
        private Button btnEditorNext;
        private Button btnEditorPrevious;
        private Button btnEditorFind;
        private NumericUpDown numericUpDownEditorId;
        private Label lblEditorSearchText;
        private Label lblEditorOrText;
        private Label lblEditorCtrlSText;
        private Label lblShifterTitle;
        private Button btnShifterOpenFile;
        private Label lblShifterShiftText;
        private Button btnShifter;
        private NumericUpDown numericUpDownShifter;
        private Label lblShifterExplainText;
        private Label lblPartialShifterTitle;
        private Button btnPartialShifterOpenFile;
        private Button btnPartialShifter;
        private FlowLayoutPanel partialShifterPanel;
        private Label label1;
    }
}