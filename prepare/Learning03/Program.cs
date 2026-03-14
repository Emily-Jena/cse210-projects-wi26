using System;

class Program
{
    static void Main(string[] args)
    {
        // number.SetTop();
        // int  topNumber = number.GetTop();
        // Console.WriteLine($"{topNumber}");

        //Step 6
        Fraction number1 = new Fraction();
        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number1.GetDecimalValue());

        Fraction number2 = new Fraction(5);
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());

        Fraction number3 = new Fraction(3,4);
        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());

        Fraction number4= new Fraction(1,3);
        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());

        //Step 7
        Random random = new Random();
        Fraction number5 = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topNumber = random.Next(1,20);
            int bottomNumber = random.Next(1,20);

            number5.SetTop(topNumber);
            number5.SetBottom(bottomNumber);

            Console.Write($"Fraction {i + 1} | ");
            Console.Write($"String:  {number5.GetFractionString()} | ");
            Console.WriteLine($"Number: {number5.GetDecimalValue.()}");
        }
    }
}