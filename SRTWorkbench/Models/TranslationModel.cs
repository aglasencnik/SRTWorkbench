namespace SRTWorkbench.Models;

public class TranslationModel
{
    public string SourceLanguage { get; set; } = string.Empty;
    public string TargetLanguage { get; set; } = string.Empty;
    public List<SubtitleModel> Subtitles { get; set; }

    public TranslationModel()
    {
        Subtitles = new List<SubtitleModel>();
    }
}
