

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}|{entry.GetRating()}";
                writer.WriteLine(line);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 4)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                int rating;
                if (!int.TryParse(parts[3], out rating))
                {
                    rating = 0; // Default rating if parsing fails
                }
                Entry entry = new Entry(prompt, response, date, rating);
                _entries.Add(entry);
            }
            else
            {
                Console.WriteLine("Warning: Skipping malformed line in file.");
            }
        }
    }
}
