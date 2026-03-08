public class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
               outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}"); 
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            
            JournalEntry newEntry = new JournalEntry(parts[0], parts[1], parts[2]);
            _entries.Add(newEntry);
        }

    }
}