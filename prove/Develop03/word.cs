class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetwordString()
    { if (!_hidden)
        {
        return _word;
        }
        else
        {
            string tempString = " ";
            foreach (char c in _word)
            {
                tempString += '_';
            }
            return tempString;
        }
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public void HideWord(bool hidden = true)
    {
        _hidden = hidden;
    }
}