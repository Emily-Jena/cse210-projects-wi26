public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public string GetDisplaytext()
    { 
        if (_hidden)
        {
        return new string('_',_text.Length); //Underscore with same length
        }
        else
        {
            
            return _text;
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