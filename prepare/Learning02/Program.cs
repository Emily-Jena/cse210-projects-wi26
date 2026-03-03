using System;

class Program{

    static void Main(string[] args)
{
     Console.WriteLine("Working with classes!");

        Job myFirstJob = new Job();
        myFirstJob._company = "Digitran";
        myFirstJob._jobTitle = "software Engineering";
        myFirstJob._startYear = 1989;
        myFirstJob._endYear = 1994;

        myFirstJob.DisplayJob();

        Job mySecondJob = new Job();
        mySecondJob._company = "Hp";
        mySecondJob._jobTitle = "Software Engineering";
        mySecondJob._startYear = 1994;
        mySecondJob._endYear = 2022;
        myFirstJob.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Bob Bubba";
        myResume._jobs = new List<Job>();
        myResume._jobs.Add(myFirstJob);
        myResume._jobs.Add(mySecondJob);
        myResume.DisplayResume();
}  
}
    
