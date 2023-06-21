using DeepL;

namespace SRTWorkbench.Models;

public class TranslationModel
{
    public string SourcePath { get; set; } = string.Empty;
    public string TargetPath { get; set; } = string.Empty;
    public string SourceLanguage { get; set; } = string.Empty;
    public List<string> TargetLanguages { get; set; }
    public List<SubtitleModel> Subtitles { get; set; }
    public int ProgressBarMaxValue { get; set; }

    public TranslationModel()
    {
        TargetLanguages = new List<string>();
        Subtitles = new List<SubtitleModel>();
    }
}
