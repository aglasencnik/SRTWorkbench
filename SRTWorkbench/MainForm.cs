using System.Diagnostics;

namespace SRTWorkbench;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void linkLblAboutProjectUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var psi = new ProcessStartInfo
        {
            FileName = "https://github.com/aglasencnik/SRTWorkbench",
            UseShellExecute = true
        };
        Process.Start(psi);
    }
}