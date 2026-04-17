public class Bicycle : Activity
{
    // VARIABLES
    private double _speed;

    // CONSTRUCTORS
    public Bicycle(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // GETTERS AND SETTERS

    // METHODS
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

}