public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitWords = text.Split(' '); // Spaces split string
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }

    }
    
    public void HideRandomWords(int numberToHide)
    {
        //Randomly Hide word if still visible 
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].HideWord();
                hiddenCount++;
            }
        }
    }

    public string GetDisplaytext()
    {
        string scriptureText = " ";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplaytext() + " ";
        } 
        return $"{_reference.GetDisplaytext()} - {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(hw => hw.IsHidden()); // Check words is Hidden
    }

}