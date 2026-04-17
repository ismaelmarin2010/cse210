public class SimpleGoal : Goal
{
    // VARIABLES
    private bool _isComplete;

    // GETTERS AND SETTERS

    // CONSTRUCTORS
    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // METHODS
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}