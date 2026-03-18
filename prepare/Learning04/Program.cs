using System;

class Program
{
    static void Main(string[] args)
    {
        // Create New Assignment & Call & Display
        Assignment testAssignment = new Assignment("Samuel Bennett" , "multiplication");

        string summary = testAssignment.GetSummary();
        Console.WriteLine(summary);
    }
}