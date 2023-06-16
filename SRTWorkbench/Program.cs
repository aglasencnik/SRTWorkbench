using System.Text;

namespace SRTWorkbench;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        catch (Exception ex)
        {
            _ = new ErrorHandler(ex);
        }
    }
}