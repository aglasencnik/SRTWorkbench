using System.Text;

namespace SRTWorkbench.Helpers;

public static class SubtitleFileHelper
{
    public static string ReadFile(string path)
    {
        // Check if file exists
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("File not found.", path);
        }

        // Read file with automatic encoding detection
        using var reader = new StreamReader(path, true);
        return reader.ReadToEnd();
    }

    public static bool WriteFile(string path, string content)
    {
        try
        {
            // Create directory if it doesn't exist
            var directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Write file with UTF-8 encoding, overwrite if exists
            using var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.Write(content);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
