using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("This is the Exercise3 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");

        // Request the user for the magic number for Parts 1 and 2
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Generate a random number for Part 3
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        // Initialize the variable that is used in the loop.
        int guessNumber = -1;

        do
        {
            // Print screen requesting the user for a number.
            Console.Write("What is your guess? ");

            // Take the number entered and save it as int (variable pre initialized)
            guessNumber = int.Parse(Console.ReadLine());

            // Do the verification to check if the user guessed
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guessNumber != magicNumber);







    }
}