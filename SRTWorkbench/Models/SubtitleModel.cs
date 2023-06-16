namespace SRTWorkbench.Models;

public class SubtitleModel
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public List<string> Lines { get; set; }

    public SubtitleModel()
    {
        Lines = new List<string>();
    }
}
