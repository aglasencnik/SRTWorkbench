using CredentialManagement;
using SRTWorkbench.Helpers;
using SRTWorkbench.Models;
using SRTWorkbench.UserControls;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace SRTWorkbench;

public partial class MainForm : Form
{
    private readonly string _credentialTarget = "SRTWorkbenchAPI";
    private string _apiKey;
    private string _filePath;
    private List<int> _editorFoundIndexes;
    private int _editorCurrentOccurrenceIndex;

    public MainForm()
    {
        try
        {
            InitializeComponent();

            _apiKey = string.Empty;
            _filePath = string.Empty;
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
            else if (currentPage == tabPageTranslator)
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
                btnShifter.Enabled = false;
                numericUpDownShifter.Value = 0;
                numericUpDownShifter.Enabled = false;
            }
            else if (currentPage == tabPagePartialShifter)
            {
                btnPartialShifter.Enabled = false;
                partialShifterPanel.Enabled = false;

                partialShifterPanel.Controls.Clear();
                partialShifterPanel.Controls.Add(new PartialShifterHeaderControl());

                var partialShifterRuleControl = new PartialShifterRuleControl();
                partialShifterRuleControl.Id = Guid.NewGuid();
                partialShifterRuleControl.RemoveButtonClicked += RemoveRuleControl;
                partialShifterPanel.Controls.Add(partialShifterRuleControl);

                var partialShifterAddControl = new PartialShifterAddControl();
                partialShifterAddControl.AddButtonClicked += AddRuleControl;
                partialShifterPanel.Controls.Add(partialShifterAddControl);
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
    private void btnHomeTranslator_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.SelectedTab = tabPageTranslator;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnHomeShifter_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.SelectedTab = tabPageShifter;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnHomePartialShifter_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.SelectedTab = tabPagePartialShifter;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnHomeEditor_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.SelectedTab = tabPageEditor;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnHomeApiSettings_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.SelectedTab = tabPageApiSettings;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnHomeAbout_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.SelectedTab = tabPageAbout;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
    #endregion

    #region Translation
    #endregion

    #region Shifting
    private void btnShifterOpenFile_Click(object sender, EventArgs e)
    {
        try
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a subtitle file you want to shift";
            openFileDialog.DefaultExt = ".srt";
            openFileDialog.Filter = "SRT files (*.srt)|*.srt|TXT files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;

                btnShifter.Enabled = true;
                numericUpDownShifter.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnShifter_Click(object sender, EventArgs e)
    {
        try
        {
            string srtContent = SubtitleFileHelper.ReadFile(_filePath);
            var subtitles = SubtitleParser.Deserialize(srtContent);
            subtitles = SubtitleShifter.ShiftAll(subtitles, Convert.ToInt32(numericUpDownShifter.Value));
            srtContent = SubtitleParser.Serialize(subtitles);
            SubtitleFileHelper.WriteFile(_filePath, srtContent);

            MessageBox.Show("Subtitle shifting completed successfully!",
                "Shifting completed!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
    #endregion

    #region PartialShifting
    private void btnPartialShifterOpenFile_Click(object sender, EventArgs e)
    {
        try
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a subtitle file you want to shift";
            openFileDialog.DefaultExt = ".srt";
            openFileDialog.Filter = "SRT files (*.srt)|*.srt|TXT files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;

                btnPartialShifter.Enabled = true;
                partialShifterPanel.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnPartialShifter_Click(object sender, EventArgs e)
    {
        try
        {
            var shifts = new List<Tuple<TimeSpan, TimeSpan, int>>();

            foreach (var control in partialShifterPanel.Controls.OfType<PartialShifterRuleControl>())
            {
                if (control.IsCompleted)
                {
                    shifts.Add(new Tuple<TimeSpan, TimeSpan, int>(control.ShiftStart, control.ShiftEnd, control.ShiftAmount));
                }
            }

            string srtContent = SubtitleFileHelper.ReadFile(_filePath);
            var subtitles = SubtitleParser.Deserialize(srtContent);
            subtitles = SubtitleShifter.ShiftPartial(subtitles, shifts);
            srtContent = SubtitleParser.Serialize(subtitles);
            SubtitleFileHelper.WriteFile(_filePath, srtContent);

            MessageBox.Show("Subtitle shifting completed successfully!",
                "Shifting completed!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void AddRuleControl(object sender, EventArgs e)
    {
        try
        {
            partialShifterPanel.Controls.RemoveAt(partialShifterPanel.Controls.Count - 1);

            var partialShifterRuleControl = new PartialShifterRuleControl();
            partialShifterRuleControl.Id = Guid.NewGuid();
            partialShifterRuleControl.RemoveButtonClicked += RemoveRuleControl;
            partialShifterPanel.Controls.Add(partialShifterRuleControl);

            var partialShifterAddControl = new PartialShifterAddControl();
            partialShifterAddControl.AddButtonClicked += AddRuleControl;
            partialShifterPanel.Controls.Add(partialShifterAddControl);
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void RemoveRuleControl(object sender, CustomEventArgs e)
    {
        try
        {
            int index = -1;

            for (int i = 0; i < partialShifterPanel.Controls.Count; i++)
            {
                if (partialShifterPanel.Controls[i] is PartialShifterRuleControl)
                {
                    var control = (PartialShifterRuleControl)partialShifterPanel.Controls[i];

                    if (control != null && control.Id == e.Id) index = i;
                }
            }

            if (index >= 0) partialShifterPanel.Controls.RemoveAt(index);
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
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
                _filePath = openFileDialog.FileName;

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
                && SubtitleFileHelper.WriteFile(_filePath, rtbxEditor.Text))
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
                tabControl.SelectedTab = tabPageTranslator;
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