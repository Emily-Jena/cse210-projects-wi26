using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do {
        // Generating random numbers - computer assisted
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int response = 0;
        int count = 0; // start of the count

        while (response != number)
            {

            Console.Write("What is the magic number? ");
            response = int.Parse(Console.ReadLine());
            count++; //increment the guessing

            if (response > number)
                {
                    Console.WriteLine("Lower");
                }
            else if (response < number)
                {
                    Console.WriteLine("Higher");
                }
            else
                {
                    Console.WriteLine($"Congratulations, You guessed it in {count}!");
                }
            } 
        Console.Write("Want to play again? (yes/no): ");
        playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");
    }
} 