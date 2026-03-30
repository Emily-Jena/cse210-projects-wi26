using System.Drawing;
using System.IO;


public class Goals
{

    private List<Goal> _goals;
    private int _score;

    public Goals()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayUserInfo();
            Console.WriteLine($"Menu options: ");
            Console.WriteLine($"1. Create New Goal");
            Console.WriteLine($"2. List Goals");
            Console.WriteLine($"3. Save Goals");
            Console.WriteLine($"4. Load Goals");
            Console.WriteLine($"5. Record Event");
            Console.WriteLine($"6. Quit");

            Console.Write($"Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal();
                break;

                case "2": ListGoalDetails();
                break;

                case "3": SaveGoals();
                break;

                case "4": LoadGoals();
                break;

                case "5": RecordEvent();
                break;

            }
        }
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"\n You have {_score} points. \n");
    }

    public void CreateGoal()
    {
        Console.WriteLine("\n The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string GoalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (GoalType)
        {
            case "1": 
                _goals.Add(new SimpleGoal(name, description, points));
            break;

            case "2":
                 _goals.Add(new EternalGoal(name, description, points));
            break;

            case "3": 
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing that many times? ");
                int bonus = int.Parse(Console.ReadLine());
            
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            break;

            default:
                Console.WriteLine($"Option Not Available. Your Goal has not been created.");
            break;
        }
    }


public void ListGoalDetails()
    {
        Console.WriteLine("\n The goals are:");
        for (int i = 0; i < _goals.Count; i++) 
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        //int index = int.Parse(Console.ReadLine()) - 1;

    //    Goal goal = _goals[index];

    //     int pointsEarned = _goals[index].RecordEvent();

    //     if (goal is ChecklistGoal checklist && !checklist.IsComplete())
    //     {
    //         goal.RecordEvent();
    //         if (checklist.IsComplete())
    //         {
    //             pointsEarned += checklist.GetBonus();
    //         }
        
    //         else
    //         {
    //             goal.RecordEvent();
    //         }
        

    //     _score += pointsEarned;
    //     Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");

if (int.TryParse(Console.ReadLine(), out int choice))
    {
        int index = choice - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }}

    }

    

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }
        string [] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[]parts = lines[i].Split(':');
            string type = parts[0];
            string[] details = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    SimpleGoal sg = new SimpleGoal(details[0], details[1], int.Parse(details[2]));

                    if (bool.Parse(details[3]))
                    {
                        sg.RecordEvent();
                    }
                    _goals.Add(sg);
                break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                break;

                case "ChecklistGoal":
                    int points = int.Parse(details[2]);
                    int bonus = int.Parse(details[3]);
                    int target =int.Parse(details[4]);
                    int currentCount = int.Parse(details[5]);

                    ChecklistGoal cg = new ChecklistGoal(details[0], details[1], points, target, bonus);

                    cg.SetAmountCompleted(currentCount);

                    _goals.Add(cg);
                break;
            }  
        }
    }
} 

