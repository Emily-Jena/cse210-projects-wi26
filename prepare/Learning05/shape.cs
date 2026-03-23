public class Shape
{
    // class member variable & constructor
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    // getter & setter
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // virtual method
    public virtual double GetArea()
    {
        return 0;
    }
}