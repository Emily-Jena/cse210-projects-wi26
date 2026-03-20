using System;

class Program
{
    static void Main(string[] args)
    {
        // Create New Assignment & Call & Display
        Assignment testAssignment1 = new Assignment("Samuel Bennett" , "multiplication");
        Console.WriteLine(testAssignment1.GetSummary());
        Console.WriteLine();

        MathAssignment testAssignment2 = new MathAssignment ("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(testAssignment2.GetSummary());
        Console.WriteLine(testAssignment2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment testAssignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(testAssignment3.GetSummary());
        Console.WriteLine(testAssignment3.GetWritingInformation());  
    }

}