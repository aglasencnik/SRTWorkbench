using CredentialManagement;
using DeepL;
using SRTWorkbench.Helpers;
using SRTWorkbench.Models;
using SRTWorkbench.UserControls;
using System.Diagnostics;
using System.Globalization;
using DeepL.Model;
using System.ComponentModel;
using System.Transactions;

namespace SRTWorkbench;

public partial class MainForm : Form
{
    private readonly string _credentialTarget = "SRTWorkbenchAPI";
    private string _apiKey;
    private string _filePath;
    private string _newFilePath;
    private List<int> _editorFoundIndexes;
    private int _editorCurrentOccurrenceIndex;
    private List<TargetLanguage> _targetLanguages;
    private int _anticipatedCheckedItemsCount;
    private TranslationModel _translation;

    public MainForm()
    {
        try
        {
            InitializeComponent();

            _apiKey = string.Empty;
            _filePath = string.Empty;
            _newFilePath = string.Empty;
            _editorFoundIndexes = new List<int>();
            _editorCurrentOccurrenceIndex = -1;
            _targetLanguages = new List<TargetLanguage>();
            _anticipatedCheckedItemsCount = 0;
            _translation = new TranslationModel();
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

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            if (translatorBackgroundWorker.IsBusy) translatorBackgroundWorker.CancelAsync();

            while (translatorBackgroundWorker.IsBusy)
            {
                Application.DoEvents();
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private async void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
    {
        this.Cursor = Cursors.WaitCursor;

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
                    await InitializeTranslator();
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
        finally
        {
            this.Cursor = Cursors.Default;
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

    #region Translator
    private void btnTranslatorSource_Click(object sender, EventArgs e)
    {
        try
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a subtitle file you want to translate";
            openFileDialog.DefaultExt = ".srt";
            openFileDialog.Filter = "SRT files (*.srt)|*.srt|TXT files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _filePath = Path.GetDirectoryName(openFileDialog.FileName) ?? string.Empty;
                tbxTranslatorSource.Text = Path.GetFileName(openFileDialog.FileName);
                tbxTranslatorSource.Enabled = true;

                CheckIfTranslationAvailable();
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void btnTranslatorTarget_Click(object sender, EventArgs e)
    {
        try
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Select a save location of the translated subtitle file";
            saveFileDialog.Filter = "SRT files (*.srt)|*.srt|TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (!string.IsNullOrWhiteSpace(tbxTranslatorSource.Text))
            {
                int lastDotIndex = tbxTranslatorSource.Text.LastIndexOf('.');

                if (lastDotIndex >= 0)
                {
                    saveFileDialog.FileName = tbxTranslatorSource.Text.Insert(lastDotIndex, "-new");
                }
                else saveFileDialog.FileName = "subtitles.srt";
            }
            else saveFileDialog.FileName = "subtitles.srt";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _newFilePath = Path.GetDirectoryName(saveFileDialog.FileName) ?? string.Empty;
                tbxTranslatorTarget.Text = Path.GetFileName(saveFileDialog.FileName);
                tbxTranslatorTarget.Enabled = true;

                CheckIfTranslationAvailable();
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private async void btnTranslatorTranslate_Click(object sender, EventArgs e)
    {
        try
        {
            if (cbxTranslatorAutomaticallyDetect.Checked
                || !checkedListBoxTranslatorTarget.CheckedItems.Contains(cbxTranslatorSource.Text))
            {
                string srtContent = SubtitleFileHelper.ReadFile(Path.Combine(_filePath, tbxTranslatorSource.Text));
                var sourceSubtitles = SubtitleParser.Deserialize(srtContent);

                int numberOfCharacters = 0;
                foreach (var subtitle in sourceSubtitles)
                {
                    foreach (var line in subtitle.Lines)
                    {
                        numberOfCharacters += line.Length;
                    }
                }
                numberOfCharacters *= checkedListBoxTranslatorTarget.CheckedItems.Count;

                var translator = new Translator(_apiKey, _translation.TranslatorOptions);
                var usage = await translator.GetUsageAsync();

                if (usage != null && usage.Character != null)
                {
                    var charactersLeft = usage.Character.Limit - usage.Character.Count;

                    if (charactersLeft >= numberOfCharacters)
                    {
                        string usedCharacters = numberOfCharacters.ToString("N0", CultureInfo.CurrentCulture);
                        var dialog = MessageBox.Show($"Do you really want to start translation?\nYou would use up approximately: {usedCharacters} characters.",
                            "Confirm translation",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (dialog == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (!translatorBackgroundWorker.IsBusy)
                            {
                                this.Cursor = Cursors.WaitCursor;

                                foreach (Control c in this.Controls)
                                {
                                    c.Enabled = false;
                                }
                                progressBarTranslator.Enabled = true;

                                _translation.SourcePath = Path.Combine(_filePath, tbxTranslatorSource.Text);
                                _translation.TargetPath = Path.Combine(_newFilePath, tbxTranslatorTarget.Text);
                                _translation.Subtitles = sourceSubtitles;
                                _translation.ProgressBarMaxValue = progressBarTranslator.Maximum;

                                if (!cbxTranslatorAutomaticallyDetect.Checked)
                                    _translation.SourceLanguage = ((KeyValuePair<string, string>)cbxTranslatorSource.SelectedItem).Key;
                                else _translation.SourceLanguage = string.Empty;

                                for (int i = 0; i < checkedListBoxTranslatorTarget.CheckedItems.Count; i++)
                                {
                                    string targetLanguage = _targetLanguages
                                        .FirstOrDefault(x => x.Name == checkedListBoxTranslatorTarget.CheckedItems[i].ToString())
                                        ?.Code
                                        ?? string.Empty;

                                    _translation.TargetLanguages.Add(targetLanguage);
                                }

                                translatorBackgroundWorker.RunWorkerAsync();
                            }
                            else MessageBox.Show("Translation could NOT be started!",
                                    "Translation couldn't be started!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Translation has been canceled!",
                                "Translation canceled!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("You don't have enough characters left!",
                            "Not enough characters left!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Usage information currently not accessible or unavailable.",
                        "Usage unknown!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else MessageBox.Show("You can't select the same target language as your source language!",
                    "You can't select one of the languages!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void translatorBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        try
        {
            var task = Task.Run(async () =>
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                var translator = new Translator(_apiKey, _translation.TranslatorOptions);
                bool isSuccess = true;
                int totalNumberOfLines = 0;
                int numOfTotalTranslatedLines = 0;
                foreach (var subtitle in _translation.Subtitles)
                {
                    totalNumberOfLines += subtitle.Lines.Count;
                }
                totalNumberOfLines *= _translation.TargetLanguages.Count;

                foreach (var targetLanguage in _translation.TargetLanguages)
                {
                    var translatedSubtitles = new List<SubtitleModel>();
                    var sourceLines = _translation.Subtitles.SelectMany(s => s.Lines).ToList();
                    var translatedLines = new List<string>();
                    int usedLines = 0;
                    int numOfTranslatedLines = 0;
                    int translationStep = 100;

                    for (int i = 0; i < (int)Math.Ceiling((double)sourceLines.Count / translationStep); i++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        var lines = sourceLines.Skip(numOfTranslatedLines).Take(translationStep).ToArray();

                        if (!string.IsNullOrWhiteSpace(_translation.SourceLanguage))
                        {
                            var translations = await translator.TranslateTextAsync(lines, _translation.SourceLanguage, targetLanguage);

                            if (translations != null)
                            {
                                translatedLines.AddRange(translations.Select(translation => translation.Text));
                            }
                        }
                        else
                        {
                            var translations = await translator.TranslateTextAsync(lines, null, targetLanguage);

                            if (translations != null)
                            {
                                translatedLines.AddRange(translations.Select(translation => translation.Text));
                            }
                        }

                        numOfTranslatedLines += lines.Length;
                        numOfTotalTranslatedLines += lines.Length;
                        int progressPercentage = (int)Math.Round((double)numOfTotalTranslatedLines / totalNumberOfLines * _translation.ProgressBarMaxValue);
                        translatorBackgroundWorker.ReportProgress(progressPercentage);
                    }

                    foreach (var subtitle in _translation.Subtitles)
                    {
                        subtitle.Lines = translatedLines.Skip(usedLines).Take(subtitle.Lines.Count).ToList();
                        translatedSubtitles.Add(subtitle);
                        usedLines += subtitle.Lines.Count;
                    }

                    if (_translation.TargetLanguages.Count > 1)
                    {
                        string path = _translation.TargetPath;
                        string translatedSrtContent = SubtitleParser.Serialize(translatedSubtitles);

                        int lastDotIndex = path.LastIndexOf('.');
                        if (lastDotIndex >= 0)
                        {
                            path = path.Insert(lastDotIndex, $"-{targetLanguage}");
                        }

                        if (!SubtitleFileHelper.WriteFile(path, translatedSrtContent)) isSuccess = false;
                    }
                    else
                    {
                        string translatedSrtContent = SubtitleParser.Serialize(translatedSubtitles);

                        if (!SubtitleFileHelper.WriteFile(_translation.TargetPath, translatedSrtContent)) isSuccess = false;
                    }
                }

                e.Result = isSuccess;
            });
            task.Wait();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
            e.Cancel = true;
        }
    }

    private void translatorBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        try
        {
            progressBarTranslator.Value = e.ProgressPercentage;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private async void translatorBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        try
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }

            await InitializeTranslator();

            this.Cursor = Cursors.Default;

            if (e.Cancelled)
            {
                MessageBox.Show("Translation was cancelled!",
                            "Translation cancelled",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            else if (e.Error != null || e.Result == null)
            {
                _ = new ErrorHandler(e.Error ?? throw new Exception("No argument was passed!"));
            }
            else
            {
                bool result = (bool)e.Result;

                if (result) MessageBox.Show("Translation has been completed successfully!",
                                "Translation completed!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                else MessageBox.Show("There has been an error while writing to one or more translated subtitle files!",
                            "Translation failed on some files!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void tbxTranslatorSource_TextChanged(object sender, EventArgs e)
    {
        try
        {
            CheckIfTranslationAvailable();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void tbxTranslatorTarget_TextChanged(object sender, EventArgs e)
    {
        try
        {
            CheckIfTranslationAvailable();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void checkedListBoxTranslatorTarget_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        try
        {
            if (e.NewValue == CheckState.Checked) _anticipatedCheckedItemsCount++;
            else _anticipatedCheckedItemsCount--;

            CheckIfTranslationAvailable();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void cbxTranslatorAutomaticallyDetect_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (cbxTranslatorAutomaticallyDetect.Checked) cbxTranslatorSource.Enabled = false;
            else cbxTranslatorSource.Enabled = true;

            CheckIfTranslationAvailable();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void cbxTranslatorSource_SelectionChangeCommitted(object sender, EventArgs e)
    {
        try
        {
            CheckIfTranslationAvailable();
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private void CheckIfTranslationAvailable()
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(tbxTranslatorSource.Text)
                && !string.IsNullOrWhiteSpace(tbxTranslatorTarget.Text)
                && _anticipatedCheckedItemsCount > 0
                && (cbxTranslatorAutomaticallyDetect.Checked == true || cbxTranslatorSource.SelectedIndex != -1))
            {
                btnTranslatorTranslate.Enabled = true;
            }
            else btnTranslatorTranslate.Enabled = false;
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }

    private async Task InitializeTranslator()
    {
        try
        {

            tbxTranslatorSource.Enabled = false;
            tbxTranslatorTarget.Enabled = false;
            tbxTranslatorSource.Text = string.Empty;
            tbxTranslatorTarget.Text = string.Empty;
            _filePath = string.Empty;
            _newFilePath = string.Empty;
            cbxTranslatorSource.DataSource = null;
            checkedListBoxTranslatorTarget.Items.Clear();
            lblTranslatorUsage.Text = string.Empty;
            progressBarTranslator.Value = 0;
            btnTranslatorTranslate.Enabled = false;
            _targetLanguages = new List<TargetLanguage>();
            _anticipatedCheckedItemsCount = 0;
            _translation = new TranslationModel();

            var options = new TranslatorOptions
            {
                sendPlatformInfo = false,
                MaximumNetworkRetries = 5,
                PerRetryConnectionTimeout = TimeSpan.FromSeconds(10),
                appInfo = new AppInfo { AppName = "SRTWorkbench", AppVersion = "1.0.0" }
            };
            _translation.TranslatorOptions = options;
            var translator = new Translator(_apiKey, options);
            var usage = await translator.GetUsageAsync();

            if (usage != null && usage.Character != null)
            {
                string usedCharacters = usage.Character.Count.ToString("N0", CultureInfo.CurrentCulture);
                string characterLimit = usage.Character.Limit.ToString("N0", CultureInfo.CurrentCulture);
                lblTranslatorUsage.Text = $"Usage: You have used {usedCharacters} characters out of your {characterLimit} character limit.";
            }
            else lblTranslatorUsage.Text = "Usage: Information currently not accessible or unavailable.";

            var sourceLanguages = await translator.GetSourceLanguagesAsync();
            var sourceLanguagesDict = new Dictionary<string, string>();

            foreach (var language in sourceLanguages)
            {
                sourceLanguagesDict.Add(language.Code, language.Name);
            }

            cbxTranslatorSource.DataSource = new BindingSource(sourceLanguagesDict, null);
            cbxTranslatorSource.DisplayMember = "Value";
            cbxTranslatorSource.ValueMember = "Key";
            cbxTranslatorSource.IntegralHeight = false;
            cbxTranslatorSource.SelectedIndex = -1;

            var targetLanguages = await translator.GetTargetLanguagesAsync();

            foreach (var language in targetLanguages)
            {
                _targetLanguages.Add(language);
                checkedListBoxTranslatorTarget.Items.Add(language.Name);
            }
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
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