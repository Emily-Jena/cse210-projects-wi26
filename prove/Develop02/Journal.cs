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
                string cleanPrompt = $"\"{entry._prompt.Replace("\"", "\"\"")}\"";
                string cleanResponse = $"\"{entry._response.Replace("\"", "\"\"")}\"";

               outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}"); 
            }
        }
        Console.WriteLine("This has been successfully saved!");
    }


    public void LoadFromFile(string filename)
    {
        _entries.Clear();string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                
            
                JournalEntry newEntry = new JournalEntry(date, prompt, response);

                _entries.Add(newEntry);
            }
        }
        Console.WriteLine("Loaded...!");

    }


}
