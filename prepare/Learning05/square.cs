public class Square : Shape
{
    // Member variable & constructor
    private double _side;
    public Square(string color, double side)
    {
        _side = side;
    }

    // override method
    public override double GetArea()
    {
        return _side * _side;
    }
}