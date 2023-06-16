namespace SRTWorkbench.Models;

public class CustomEventArgs : EventArgs
{
    public Guid Id { get; set; }

    public CustomEventArgs(Guid _id)
    {
        Id = _id;
    }
}
