public class Fraction
{
    // V A R I A B L E S
    private int _top;
    private int _bottom;


    // C O N S T R U C T O R S    
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // G E T T E R S   A N D   S E T T E R S
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // When both values are int, the result will be int as well.
        // Forced the result to be double by making one if the elements double.
        return (double)_top / _bottom;
    }

}