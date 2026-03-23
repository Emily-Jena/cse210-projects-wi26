using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.Write("Select a choice from the menu.");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Begin Breathing Activity");
            Console.WriteLine("2. Begin Reflecting Activity");
            Console.WriteLine("3. Begin Listing Activity ");
            Console.WriteLine("4. Quit");
            
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BreathingActivity = new BreathingActivity();
                    breathing.Run();
                break;

                case "2":
                    ReflectionActivity = new ReflectionActivity();
                    ReflectionActivity.Run();
                break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                break;

                case "4":
                    running = false;
                break;

                default:
                    Console.WriteLine("\n That option is not available. Please try again.");
                    Thread.Sleep(1000);
                break;
            }
        }

    }
}