using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Event Planning Program!");

        Address address1 = new Address("90 Park St", "Rexburg", "ID", "83440");
        Address address2 = new Address("560 Heven Ave", "Lendony", "UT", "90902");
        Address address3 = new Address("670 Turning Dr", "Kalma", "CA", "87837");

        Lectures lecture = new Lectures("Technological Impacts Advancements", "A documentary on technological structures","08/20/2023", "5:00 PM", address1, "Pres. Kesson", 50);
        Receptions reception = new Receptions("Tech Talk", "STEM Innovations", "11/02/1990", "07:30 AM", address2, "rsvp@techtalk.com");
        Outdoor outdoor = new Outdoor("Winter Skating", "Ice skating ar the rink", "12/12/2026", "12:00 PM", address3, "Snowy and 25°F");

        List<Event> events = new List<Event> {lecture, reception, outdoor};

        bool running = true;
        while (running)
        {
    
            Console.WriteLine("");
            Console.WriteLine("Marketing Events Options");
            Console.WriteLine("");
            Console.WriteLine("1. Lecture");
            Console.WriteLine("2. Reception");
            Console.WriteLine("3. Outdoor");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.Write("Select an event to view the marketing details: ");

            string choice = Console.ReadLine();
            Event selectedEvent = null;

            switch (choice)
            {
                case "1":
                Console.Clear();
                selectedEvent = events[0];
                break;
                case "2":
                Console.Clear();
                selectedEvent = events[1];
                break;
                case "3":
                Console.Clear();
                selectedEvent = events[2];
                break;
                case "4":
                Console.Clear();
                running = false;
                continue;
                default:
                Console.WriteLine("You must have pressed a wrong number. Try again!");
                Console.ReadLine();
                continue;

            }
        

        if (selectedEvent != null)
        {
            Console.Clear();
            Console.WriteLine("=========================================");

            Console.WriteLine($"Standard Details: \n{selectedEvent.GetStandardDetails()}");
            Console.WriteLine("");

            Console.WriteLine($"Full Details: \n{selectedEvent.GetFullDetails()}");
            Console.WriteLine("");

            Console.WriteLine($"Short Description: \n{selectedEvent.GetShortDescription()}");
            Console.WriteLine("=========================================");
        }

        }
    }
}