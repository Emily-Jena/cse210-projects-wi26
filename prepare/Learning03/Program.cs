using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction();
        number.SetTop(5);

        int  topNumber = number.GetTop();

        Console.WriteLine($"{topNumber}");

        
    }
}