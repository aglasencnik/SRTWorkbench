using SRTWorkbench.Models;

namespace SRTWorkbench.UserControls;

public partial class PartialShifterRuleControl : UserControl
{
    public Guid Id { get; set; }
    public TimeSpan ShiftStart { get; set; }
    public TimeSpan ShiftEnd { get; set; }
    public int ShiftAmount { get; set; }
    public bool IsCompleted { get; set; }
    public delegate void RemoveButtonClickedHandler(object sender, CustomEventArgs e);
    public event RemoveButtonClickedHandler RemoveButtonClicked;
    private readonly string _placeholderText = "hh:mm:ss:fff";

    public PartialShifterRuleControl()
    {
        InitializeComponent();

        ShiftStart = TimeSpan.Zero;
        ShiftEnd = TimeSpan.Zero;
        ShiftAmount = 0;
        IsCompleted = false;

        tbxStart.Text = _placeholderText;
        tbxStart.ForeColor = Color.Gray;
        tbxEnd.Text = _placeholderText;
        tbxEnd.ForeColor = Color.Gray;
    }

    private void tbxStart_TextChanged(object sender, EventArgs e)
    {
        string[] timeParts = tbxStart.Text.Split(':');

        if (timeParts.Length > 0)
        {
            int hours = 0, minutes = 0, seconds = 0, milliseconds = 0;

            int.TryParse(timeParts[0], out hours);

            int days = hours / 24;
            hours = hours % 24;

            if (timeParts.Length >= 2) int.TryParse(timeParts[1], out minutes);
            if (timeParts.Length >= 3) int.TryParse(timeParts[2], out seconds);
            if (timeParts.Length >= 4) int.TryParse(timeParts[3], out milliseconds);

            if (minutes <= 60 && seconds <= 60 && milliseconds <= 999)
                ShiftStart = new TimeSpan(days, hours, minutes, seconds, milliseconds);
        }

        CheckIfCompleted();
    }

    private void tbxEnd_TextChanged(object sender, EventArgs e)
    {
        string[] timeParts = tbxEnd.Text.Split(':');

        if (timeParts.Length > 0)
        {
            int hours = 0, minutes = 0, seconds = 0, milliseconds = 0;

            int.TryParse(timeParts[0], out hours);

            int days = hours / 24;
            hours = hours % 24;

            if (timeParts.Length >= 2) int.TryParse(timeParts[1], out minutes);
            if (timeParts.Length >= 3) int.TryParse(timeParts[2], out seconds);
            if (timeParts.Length >= 4) int.TryParse(timeParts[3], out milliseconds);

            if (minutes <= 60 && seconds <= 60 && milliseconds <= 999)
                ShiftEnd = new TimeSpan(days, hours, minutes, seconds, milliseconds);
        }

        CheckIfCompleted();
    }

    private void numericUpDown_ValueChanged(object sender, EventArgs e)
    {
        ShiftAmount = Convert.ToInt32(numericUpDown.Value);

        CheckIfCompleted();
    }

    private void CheckIfCompleted()
    {
        if (ShiftAmount != 0 && ShiftStart < ShiftEnd) IsCompleted = true;
        else IsCompleted = false;
    }

    private void tbxStart_Enter(object sender, EventArgs e)
    {
        if (tbxStart.Text == _placeholderText)
        {
            tbxStart.Text = string.Empty;
            tbxStart.ForeColor = Color.Black;
        }
    }

    private void tbxStart_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbxStart.Text))
        {
            tbxStart.Text = _placeholderText;
            tbxStart.ForeColor = Color.Gray;
        }
    }

    private void tbxEnd_Enter(object sender, EventArgs e)
    {
        if (tbxEnd.Text == _placeholderText)
        {
            tbxEnd.Text = string.Empty;
            tbxEnd.ForeColor = Color.Black;
        }
    }

    private void tbxEnd_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbxEnd.Text))
        {
            tbxEnd.Text = _placeholderText;
            tbxEnd.ForeColor = Color.Gray;
        }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        RemoveButtonClicked?.Invoke(this, new CustomEventArgs(Id));
    }
}
