using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
// abstract methods
    public abstract int RecordEvent();

    // See if goal is done
    public abstract bool IsComplete();

    // To save to file
    public abstract string GetStringRepresentation();
    
// virtual methods- goal appear on list
    public virtual string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "[X]" : "[ ]";
        return $"{statusSymbol} {_name} ({_description})";
    }
} 