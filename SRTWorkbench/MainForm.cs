using CredentialManagement;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SRTWorkbench;

public partial class MainForm : Form
{
    private readonly string _credentialTarget = "SRTWorkbenchAPI";
    private string _apiKey;

    public MainForm()
    {
        try
        {
            InitializeComponent();
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

            if (!string.IsNullOrWhiteSpace(tbxApiSettingsApiKey.Text)) tabControl.SelectedTab = tabPageTranslation;
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