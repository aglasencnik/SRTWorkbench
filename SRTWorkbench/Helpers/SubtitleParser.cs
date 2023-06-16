using SRTWorkbench.Models;
using System.Globalization;
using System.Text;

namespace SRTWorkbench.Helpers;

public static class SubtitleParser
{
    public static string Serialize(List<SubtitleModel> subtitles)
    {
        var sb = new StringBuilder();
        foreach (var subtitle in subtitles)
        {
            sb.AppendLine(subtitle.Id.ToString());
            sb.AppendLine($"{FormatTime(subtitle.StartTime)} --> {FormatTime(subtitle.EndTime)}");
            subtitle.Lines.ForEach(line => sb.AppendLine(line));
            sb.AppendLine();
        }
        return sb.ToString();
    }

    public static List<SubtitleModel> Deserialize(string data)
    {
        var subtitleBlocks = data.Split(
            new[] { "\r\n\r\n", "\r\r", "\n\n" },
            StringSplitOptions.RemoveEmptyEntries
        );

        var subtitles = new List<SubtitleModel>();
        foreach (var block in subtitleBlocks)
        {
            var lines = block.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            var subtitle = new SubtitleModel
            {
                Id = TryParseId(lines[0]),
                StartTime = TryParseTime(lines[1].Split(" --> ")[0]),
                EndTime = TryParseTime(lines[1].Split(" --> ")[1]),
                Lines = lines.Skip(2).ToList()
            };
            subtitles.Add(subtitle);
        }

        return subtitles;
    }

    private static string FormatTime(TimeSpan timeSpan)
    {
        return $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2},{timeSpan.Milliseconds:D3}";
    }

    private static TimeSpan TryParseTime(string time)
    {
        TimeSpan timeSpan;
        if (!TimeSpan.TryParseExact(time, @"hh\:mm\:ss\,fff", CultureInfo.InvariantCulture, out timeSpan))
        {
            // handle parsing error - here we return TimeSpan.Zero for simplicity
            return TimeSpan.Zero;
        }
        return timeSpan;
    }

    private static int TryParseId(string id)
    {
        int idInt;
        if (!int.TryParse(id, out idInt))
        {
            // handle parsing error - here we return 0 for simplicity
            return 0;
        }
        return idInt;
    }
}
