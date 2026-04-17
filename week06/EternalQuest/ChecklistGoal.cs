public class ChecklistGoal : Goal
{
    // VARIABLES
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // GETTERS AND SETTERS
    public int GetBonus()
    {
        return _bonus;
    }

    public int GetCompletedCount()
    {
        return _amountCompleted;
    }

    // CONSTRUCTORS
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted)
    : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    // METHODS
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}