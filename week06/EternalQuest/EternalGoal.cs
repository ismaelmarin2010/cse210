public class EternalGoal : Goal
{
    // VARIABLES
    // No needed

    // GETTERS AND SETTERS

    // CONSTRUCTORS
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // METHODS
    public override void RecordEvent()
    {
        // When are eternal goals completed?
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}