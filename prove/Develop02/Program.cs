using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to My Journal!");
    

    Journal myJournal = new Journal();
    bool running = true;

    while (running)
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        string choice = Console.ReadLine();

    }

    switch (choice)
    {
        
        case "1":
        string date = DateTime.Now.ToShortDateString();
                string prompt = "What was the best part of my day?"; 
                Console.WriteLine($"\n{prompt}");
                string response = Console.ReadLine();
                
                myJournal.AddEntry(new JournalEntry(date, prompt, response));
        break;

        case "2":
            myJournal.DisplayEntries();
        break;

        case "3":
            Console.Write("Enter filename: ");
            string loadFile = Console.ReadLine();
            myJournal.LoadFromFile(loadFile);
        break;

        case "4":
            Console.Write("Enter filename: ");
            string saveFile = Console.ReadLine();
            myJournal.SaveToFile(saveFile);
        break;

        case "5":
            running = false;
        break;

        default:
        Console.WriteLine("You entered a wrong number. Please try again.");
        break;
    }

   }
}

