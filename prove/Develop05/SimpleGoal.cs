public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Mark and add points
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Show complete symbol
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Save/load format
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_name}, {_description}, {_points}, {_isComplete} ";
    }

}