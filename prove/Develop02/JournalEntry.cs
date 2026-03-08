class JournalEntry
{
    public string _date;
    public string _response;
    public string _prompt;

    public JournalEntry(){}

    public JournalEntry(string date, string response, string prompt)
    {
        
        _date = date;
        _response = response;
        _prompt = prompt;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }
}