namespace SRTWorkbench.UserControls;

public partial class PartialShifterAddControl : UserControl
{
    public event EventHandler AddButtonClicked;

    public PartialShifterAddControl()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        AddButtonClicked?.Invoke(this, EventArgs.Empty);
    }
}
