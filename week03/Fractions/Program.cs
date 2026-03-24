using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Fractions Project.\n");

        Console.WriteLine("TESTING CONSTRUCTORS...");

        Console.WriteLine("\nGenerate a Fraction with the default top and bottom values:");
        Fraction def = new Fraction();

        Console.WriteLine("\nGenerate a Fraction with the default bottom value");
        Console.WriteLine("Enter the value for the top: ");
        int top = int.Parse(Console.ReadLine());
        Fraction bottomLess = new Fraction(top);

        Console.WriteLine("\nGenerate a Fraction with both values from user");
        Console.WriteLine("Enter the value for the top: ");
        int numerator = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for the bottom: ");
        int denominator = int.Parse(Console.ReadLine());
        Fraction fraction = new Fraction(numerator, denominator);


        Console.WriteLine("\nTESTING GETTERS AND SETTERS...");

        Console.WriteLine("\nTesting GetFractionString()");
        Console.WriteLine(def.GetFractionString());
        Console.WriteLine(bottomLess.GetFractionString());
        Console.WriteLine(fraction.GetFractionString());

        Console.WriteLine("\nTesting GetDecimalValue()");
        Console.WriteLine(def.GetDecimalValue());
        Console.WriteLine(bottomLess.GetDecimalValue());
        Console.WriteLine(fraction.GetDecimalValue());



    }
}