using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 1, 5, 6);

        // Create Scripture
        string text = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";

        Scripture scripture = new Scripture(reference, text);
        string input = " ";

        // Loop
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplaytext());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(5); //Hidding total number of...
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplaytext());
        Console.WriteLine("\n All words are hidden. Well done!");

    }
}