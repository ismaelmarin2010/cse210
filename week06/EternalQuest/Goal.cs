public abstract class Goal
{
    // VARIABLES
    private string _shortName;
    private string _description;
    private int _points;

    // GETTERS AND SETTERS
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }


    // CONSTRUCTORS
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // METHODS
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();

}