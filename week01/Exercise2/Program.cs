using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("");

        Console.Write("What is your percentage? ");
        string strPercentage = Console.ReadLine();
        int percentage = int.Parse(strPercentage);
        string letter = "None";
        
        if (percentage >= 90 && percentage <= 100)
        {
            letter = "A";
        }

        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }

        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }

        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }

        else if (percentage < 60)
        {
            letter = "F";
        }

        else
        {
            Console.WriteLine("The percentage entered is invalid.");
        }


        if (percentage >= 70 && percentage <= 100)
        {
            Console.WriteLine($"Your grade is {letter}.");
            Console.WriteLine("Contratulations! You passed the course!");
        }

        else if (percentage < 70 && percentage >= 0)
        {
            Console.WriteLine($"Your grade is {letter}.");
            Console.WriteLine("You failed the course. Try again!");
        }

        else
        {
            Console.WriteLine("Please run the program again...");
        }

        Console.WriteLine("");
    }
}