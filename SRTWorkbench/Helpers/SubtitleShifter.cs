using SRTWorkbench.Models;

namespace SRTWorkbench.Helpers;

public static class SubtitleShifter
{
    public static List<Subtitle> ShiftAll(List<Subtitle> subtitles, int shiftAmountMilliseconds)
    {
        var shiftAmount = TimeSpan.FromMilliseconds(shiftAmountMilliseconds);

        foreach (var subtitle in subtitles)
        {
            ShiftSubtitle(subtitle, shiftAmount);
        }

        return subtitles;
    }

    public static List<Subtitle> ShiftPartial(List<Subtitle> subtitles, List<Tuple<TimeSpan, TimeSpan, int>> shifts)
    {
        foreach (var shift in shifts)
        {
            var shiftStart = shift.Item1;
            var shiftEnd = shift.Item2;
            var shiftAmount = TimeSpan.FromMilliseconds(shift.Item3);

            foreach (var subtitle in subtitles)
            {
                if (subtitle.StartTime >= shiftStart && subtitle.EndTime <= shiftEnd)
                {
                    ShiftSubtitle(subtitle, shiftAmount);
                }
            }
        }

        return subtitles;
    }

    private static void ShiftSubtitle(Subtitle subtitle, TimeSpan shiftAmount)
    {
        var startTime = subtitle.StartTime + shiftAmount;
        var endTime = subtitle.EndTime + shiftAmount;

        // Make sure times are not negative
        subtitle.StartTime = startTime.TotalMilliseconds < 0 ? TimeSpan.Zero : startTime;
        subtitle.EndTime = endTime.TotalMilliseconds < 0 ? TimeSpan.Zero : endTime;
    }
}
