using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 2);
        Console.WriteLine($"The color of the Square is {square.GetColor()}");
        Console.WriteLine($"The area of the Square is {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 2, 4);
        Console.WriteLine($"The color of the Rectangle is {rectangle.GetColor()}");
        Console.WriteLine($"The area of the Rectangle is {rectangle.GetArea()}");

        Circle circle = new Circle("Yellow", 4);
        Console.WriteLine($"The color of the Circle is {circle.GetColor()}");
        Console.WriteLine($"The area of the Circle is {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 2));
        shapes.Add(new Rectangle("Blue", 2, 4));
        shapes.Add(new Circle("Yellow", 4));

        Console.WriteLine("\nThis is the 'for' loop...\n");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color of the shape is {shape.GetColor()}");
            Console.WriteLine($"The area of the shape is {shape.GetArea()}");
            Console.WriteLine("");
        }


    }
}