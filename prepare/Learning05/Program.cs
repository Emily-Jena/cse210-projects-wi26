using System;

class Program
{
    static void Main(string[] args)
    {
        //Square
        Square s1 = new Square("Red", 5);

        // string  color = s1.GetColor();
        // double area = s1.GetArea();

        Console.WriteLine($"The square color is {s1.GetColor()} and the area is {s1.GetArea()}.");

        // Rectangle
        Rectangle s2 = new Rectangle("blue", 2, 3);

        // string color = s2.GetColor();
        // double area = s2.GetArea();

        Console.WriteLine($"The rectangle color is {s2.GetColor()} and the area is {s2.GetArea()}.");

        //Circle
    }
}