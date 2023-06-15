﻿namespace SRTWorkbench;

public class ErrorHandler
{
    public ErrorHandler(Exception ex)
    {
        try
        {
            error(ex);
        }
        catch
        {
            Environment.Exit(1);
        }
    }

    public void error(Exception ex)
    {
        try
        {
            if (MessageBox.Show("The application has encountered an unexpected error!" + Environment.NewLine + "Do you want to see more details?", "Error!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            else
            {
                Environment.Exit(1);
            }
        }
        catch
        {
            Environment.Exit(1);
        }
    }
}
