using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;

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
        }

        if (number != 0)
        {
            numbers.Add(number);          
        }
        // Compute Sum
        
        //Compute Average

        //Compute Max
    }
}