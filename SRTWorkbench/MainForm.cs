using CredentialManagement;
using SRTWorkbench.Helpers;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace SRTWorkbench;

public partial class MainForm : Form
{
    private readonly string _credentialTarget = "SRTWorkbenchAPI";
    private string _apiKey;
    private string _editorFilePath;
    private List<int> _editorFoundIndexes;
    private int _editorCurrentOccurrenceIndex;

    public MainForm()
    {
        try
        {
            InitializeComponent();

            _apiKey = string.Empty;
            _editorFilePath = string.Empty;
            _editorFoundIndexes = new List<int>();
            _editorCurrentOccurrenceIndex = -1;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
    {
        try
        {
            TabPage currentPage = e.TabPage;

            if (currentPage == tabPageHome)
            {

            }
            else if (currentPage == tabPageTranslation)
            {
                var cm = new Credential { Target = _credentialTarget };
                if (!cm.Load() || string.IsNullOrWhiteSpace(cm.Password))
                {
                    MessageBox.Show($"Your DeepL API Key is not set!{Environment.NewLine}Please set it in the Api Settings page.",
                        "API Key not set!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tabControl.SelectedTab = tabPageApiSettings;
                }
                else
                {
                    _apiKey = cm.Password;
                }
            }
            else if (currentPage == tabPageShifter)
            {

            }
            else if (currentPage == tabPagePartialShifter)
            {

            }
            else if (currentPage == tabPageEditor)
            {
                rtbxEditor.Text = string.Empty;
                numericUpDownEditorId.Value = 0;
                numericUpDownEditorId.Enabled = false;
                btnEditorFind.Enabled = false;
                btnEditorPrevious.Enabled = false;
                btnEditorNext.Enabled = false;
                btnEditorSaveFile.Enabled = false;
            }
            else if (currentPage == tabPageApiSettings)
            {
                var cm = new Credential { Target = _credentialTarget };
                if (cm.Load())
                {
                    tbxApiSettingsApiKey.Text = cm.Password ?? string.Empty;
                }

                tbxApiSettingsApiKey.UseSystemPasswordChar = true;
                btnApiSettingsShowPassword.BackgroundImage = Properties.Resources.eye_closed;
            }
            else if (currentPage == tabPageAbout)
            {

            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    #region Home
    #endregion

    #region Translation
    #endregion

    #region Shifting
    #endregion

    #region PartialShifting
    #endregion

    #region Editor
    private void btnEditorOpenFile_Click(object sender, EventArgs e)
    {
        try
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a subtitle file you want to edit";
            openFileDialog.DefaultExt = ".srt";
            openFileDialog.Filter = "SRT files (*.srt)|*.srt|TXT files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtbxEditor.Text = SubtitleFileHelper.ReadFile(openFileDialog.FileName) ?? string.Empty;
                _editorFilePath = openFileDialog.FileName;

                numericUpDownEditorId.Enabled = true;
                btnEditorFind.Enabled = true;
                btnEditorSaveFile.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnEditorSaveFile_Click(object sender, EventArgs e)
    {
        try
        {
            SaveEditorChanges();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void rtbxEditor_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveEditorChanges();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnEditorFind_Click(object sender, EventArgs e)
    {
        try
        {
            string searchId = numericUpDownEditorId.Value.ToString();

            _editorFoundIndexes.Clear();

            int startIndex = 0;
            while ((startIndex = rtbxEditor.Text.IndexOf(searchId, startIndex)) != -1)
            {
                _editorFoundIndexes.Add(startIndex);
                startIndex += searchId.Length;
            }

            if (_editorFoundIndexes.Count > 0)
            {
                rtbxEditor.SelectAll();
                rtbxEditor.SelectionBackColor = Color.White;

                _editorCurrentOccurrenceIndex = 0;
                SelectFoundText();

                btnEditorPrevious.Enabled = false;
                btnEditorNext.Enabled = (_editorFoundIndexes.Count > 1);
            }
            else
            {
                MessageBox.Show("Id has NOT been found!",
                    "Id not found!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnEditorPrevious_Click(object sender, EventArgs e)
    {
        try
        {
            rtbxEditor.SelectAll();
            rtbxEditor.SelectionBackColor = Color.White;

            if (_editorCurrentOccurrenceIndex > 0)
            {
                _editorCurrentOccurrenceIndex--;
                SelectFoundText();
            }

            btnEditorPrevious.Enabled = (_editorCurrentOccurrenceIndex > 0);
            btnEditorNext.Enabled = true;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnEditorNext_Click(object sender, EventArgs e)
    {
        try
        {
            rtbxEditor.SelectAll();
            rtbxEditor.SelectionBackColor = Color.White;

            if (_editorCurrentOccurrenceIndex < _editorFoundIndexes.Count - 1)
            {
                _editorCurrentOccurrenceIndex++;
                SelectFoundText();
            }

            btnEditorPrevious.Enabled = true;
            btnEditorNext.Enabled = (_editorCurrentOccurrenceIndex < _editorFoundIndexes.Count - 1);
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void SelectFoundText()
    {
        try
        {
            string searchId = numericUpDownEditorId.Value.ToString();
            rtbxEditor.SelectionStart = _editorFoundIndexes[_editorCurrentOccurrenceIndex];
            rtbxEditor.SelectionLength = searchId.Length;
            rtbxEditor.SelectionBackColor = Color.Yellow;
            rtbxEditor.ScrollToCaret();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void SaveEditorChanges()
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(rtbxEditor.Text)
                && SubtitleFileHelper.WriteFile(_editorFilePath, rtbxEditor.Text))
            {
                MessageBox.Show("File saved successfully!",
                    "File saved successfully!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
    #endregion

    #region ApiSettings
    private void btnApiSettingsSaveChanges_Click(object sender, EventArgs e)
    {
        try
        {
            var cm = new Credential { Target = _credentialTarget };

            if (!string.IsNullOrWhiteSpace(tbxApiSettingsApiKey.Text))
            {
                _ = new Credential
                {
                    Target = _credentialTarget,
                    Username = _credentialTarget,
                    Password = tbxApiSettingsApiKey.Text,
                    PersistanceType = PersistanceType.LocalComputer
                }.Save();
            }
            else
            {
                if (cm.Load())
                {
                    _ = new Credential { Target = _credentialTarget }.Delete();
                }
            }

            MessageBox.Show("Credentials updated successfully!",
                "Credentials updated!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (!string.IsNullOrWhiteSpace(tbxApiSettingsApiKey.Text))
            {
                tbxApiSettingsApiKey.Text = string.Empty;
                tabControl.SelectedTab = tabPageTranslation;
            }
            else tabControl.SelectedTab = tabPageHome;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnApiSettingsShowPassword_Click(object sender, EventArgs e)
    {
        try
        {
            if (tbxApiSettingsApiKey.UseSystemPasswordChar)
            {
                tbxApiSettingsApiKey.UseSystemPasswordChar = false;
                btnApiSettingsShowPassword.BackgroundImage = Properties.Resources.eye;
            }
            else
            {
                tbxApiSettingsApiKey.UseSystemPasswordChar = true;
                btnApiSettingsShowPassword.BackgroundImage = Properties.Resources.eye_closed;
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
    #endregion

    #region About
    private void linkLblAboutProjectUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/aglasencnik/SRTWorkbench",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
    #endregion
}