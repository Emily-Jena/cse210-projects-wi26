using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Heading
        Console.WriteLine("Generating a Number List, Enter 0 to Finish");
        // --------------------------------------
  

        //Add List items e.g python: numbers = []
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
        
        // Add the numbers to the list
        if (number != 0)
        {
            numbers.Add(number);          
        }
        }
        // Compute Sum
        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        //Compute Average
        double avg = numbers.Average();
        Console.WriteLine($"The average is: {avg}");

        //Compute Max
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        //Sorted List
        //Small -> large
        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int smallBig in numbers)
        {
            Console.WriteLine(smallBig);
        }
    }
}