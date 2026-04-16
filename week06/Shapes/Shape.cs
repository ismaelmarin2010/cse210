public class Shape
{
    // VARIABLE
    private string _color;

    // GETTER AND SETTER
    public string GetColor()
    {
        return _color;
    }

    private void SetColor(string color)
    {
        _color = color;
    }

    // CONSTRUCTOR
    public Shape(string color)
    {
        SetColor(color);
    }

    public virtual double GetArea()
    {
        double area = 0.00;
        return area;
    }
}