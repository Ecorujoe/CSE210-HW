using System.Collections.Generic;
using System.IO;




public class Journal
{


    public List<Entry> _entries = new List<Entry>();
    // create the list for entries
    public Journal()
    {
        _entries = new List<Entry>();
    }
    // How to store entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // display codes
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No Entries Found.");
            return;
        }
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()

    {
        string file = "C:/Users/ECORU/cse210.002/CSE210-HW/week02/Journal/journal.csv";
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            outputfile.WriteLine("Date,Prompt, EntryText");
            foreach (var entry in _entries)
            {
                string sanitizedEntryText = entry._entryText.Replace(",", ";");
                outputfile.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{sanitizedEntryText}\"");

            }
            Console.WriteLine($"Journal has been saved to {file}");
        }
    }

    public void LoadFromFile()
    {
        string file = "C:/Users/ECORU/cse210.002/CSE210-HW/week02/Journal/journal.csv";

        if (File.Exists(file))

        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                if (parts.Length >= 3)
                {
                    string date = parts[0];
                    string propmt = parts[1];
                    string entryText = parts[2];

                    Entry entry = new Entry(date, propmt, entryText);
                    _entries.Add(entry);
                } 
            }
        }
    }
}
