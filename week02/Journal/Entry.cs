using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }

    public Entry(string date, string prompt, string response, string mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Mood: {Mood}/10");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public string ToCsv()
    {
        return $"\"{Date}\",\"{Prompt}\",\"{Response}\",\"{Mood}\"";
    }

    public static Entry FromCsv(string line)
    {
        string[] parts = ParseCsv(line);

        return new Entry(
            parts[0],
            parts[1],
            parts[2],
            parts[3]
        );
    }

    private static string[] ParseCsv(string line)
    {
        line = line.Replace("\"", "");
        return line.Split(',');
    }
}