public abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

// virtual methods to override
    public int GetMinutes() => _minutes;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public string GetSummary() 
    {
        return $"{_date} - {GetType().Name} ({_minutes} min): " + $"Distance {GetDistance(): 0.0}, | Speed {GetSpeed(): 0.0}, | Pace{GetPace(): 0.0}";

    }
}