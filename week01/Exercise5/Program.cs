using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;         
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            return number;
        }

        static int SquareNumber(int favouriteNumber)
        {
            int square = favouriteNumber * favouriteNumber;
            return square;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}.");
        }
        //////////////////////////

        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(name, square);
        }

        Main();

        Console.WriteLine("");
    }
}