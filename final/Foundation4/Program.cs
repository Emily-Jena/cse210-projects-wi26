using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracking!"); 

        List<Activity> activities = new List<Activity>();

        Running run = new Running("03 Nov 2022", 30, 3.0);
        activities.Add(run);

        Cycling bicycle = new Cycling("06 Nov 2022", 30, 4.8);
        activities.Add(bicycle);

        Swimming swim = new Swimming("11 Nov 2022", 20, 20);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}