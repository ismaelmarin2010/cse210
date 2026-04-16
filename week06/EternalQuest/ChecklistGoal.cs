public class ChecklistGoal : Goal
{
    // VARIABLES
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // GETTERS AND SETTERS

    // CONSTRUCTORS
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // METHODS
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}