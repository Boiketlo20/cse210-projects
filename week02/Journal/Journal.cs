using System.Diagnostics.Contracts;
using System.Runtime.Serialization;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);  
    }

    public void DisplayAll()
    {
        foreach (Entry entries in _entries)
        {
            entries.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fullPath = Path.GetFullPath(file);
        Console.WriteLine($"Attempting to save to: {fullPath}");
        
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                sw.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved successfully to: {fullPath}");
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader filename = new StreamReader(file))
        {
            string line;
            while ((line = filename.ReadLine()) != null)
            {
            string[] parts = line.Split(',');
            if (parts.Length < 3) // Skip invalid lines
            {
                Console.WriteLine($"Skipping malformed line: {line}");
                continue;
            }
            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}