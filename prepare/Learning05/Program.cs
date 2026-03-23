using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Red", 5);
        string  color = s1.GetColor();

        double area = s1.GetArea();

        Console.WriteLine($"The square color is {color} and the area is {area}.");
    }
}