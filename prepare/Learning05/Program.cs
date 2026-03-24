using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
        //Square
        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        // Rectangle
        Rectangle s2 = new Rectangle("blue", 2, 3);
        shapes.Add(s2);

        //Circle
        Circle s3 = new Circle("White", 3);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The circle color is {color} and the area is {area}.");
        }
        

        


    }
}