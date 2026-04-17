public class Swimming : Activity
{
    // VARIABLES
    private int _laps;

    // CONSTRUCTORS
    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // GETTERS AND SETTERS

    // METHODS
    public override double GetDistance()
    {
        // meters -> km
        return (_laps * 50.0) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

}