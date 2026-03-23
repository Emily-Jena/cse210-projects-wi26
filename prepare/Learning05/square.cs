public class Square : Shape
{
    // Member variable & constructor & add base
    
    private double _side;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // override method
    public override double GetArea()
    {
        return _side * _side;
    }
}