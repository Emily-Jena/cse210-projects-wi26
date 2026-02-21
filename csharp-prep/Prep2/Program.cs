using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float finalgrade = float.Parse(grade);

        string letter = "";
            if (finalgrade >= 90)
            {
                letter = "A";
            }
            else if (finalgrade >= 80)
            {
                letter = "B";
            }
            else if (finalgrade >= 70)
            {
                letter = "C";
            }
            else if (finalgrade >= 60)
            {
               letter = "D";
            }
            else
            {
                letter = "F";
            }

        Console.WriteLine($"Your grade is: {letter}.");
        
    }
}