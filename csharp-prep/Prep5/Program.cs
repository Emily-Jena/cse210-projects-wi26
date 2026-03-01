using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Working with Functions!");
        // -------------------------------------------
        DisplayWelcomeMessage();

        string inputName = PromptUserName();
        int inputNum = PromptFavNumber();
        int squaredNum = SquareNumber(inputNum);
        int birthYear = PromptBirthYear();
        int ageNum = PromptAgeNumber(birthYear);

        DisplayResult(inputName, squaredNum, ageNum);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program");
    }
    
    // Enter Name
    static string PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    
    // Enter Fav Number
    static int PromptFavNumber()
    {
        Console.Write($"Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    // Enter Birth Year
    static int PromptBirthYear()
    {
        Console.Write($"Please enter the year you were born: ");
        int year = int.Parse(Console.ReadLine());
        return year;
    }

    // Calculate Square Num
    static int SquareNumber(int favNum)
    {
        int sqNum = favNum * favNum;
        return sqNum;
    }

    // Calculate Age
    static int PromptAgeNumber(int year)
    {
        int totalAge = 2026 - year;
        return totalAge;
    }
    static void DisplayResult(string UserName, int sqNum, int totalAge)
    {
        Console.WriteLine($"{UserName}, the square of your number is {sqNum}.");
        Console.WriteLine($"{UserName}, you will turn {totalAge} this year.");
    }
}