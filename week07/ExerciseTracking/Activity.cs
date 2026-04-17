public abstract class Activity
{
    // VARIABLES
    private string _date;
    private int _minutes;

    // CONSTRUCTORS
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // GETTERS AND SETTERS
    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // METHODS
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance():F2} km, Speed {GetSpeed():F2} km/h, Pace: {GetPace():F2} min per km";
    }

}