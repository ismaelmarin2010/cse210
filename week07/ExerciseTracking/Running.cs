public class Running : Activity
{
    // VARIABLES
    private double _distance;

    // CONSTRUCTORS
    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // GETTERS AND SETTERS

    // METHODS
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

}