namespace SRTWorkbench.Models;

public class Subtitle
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public List<string> Lines { get; set; }

    public Subtitle()
    {
        Lines = new List<string>();
    }
}
