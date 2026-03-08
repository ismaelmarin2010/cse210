using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello Handsome! This is the Exercise3 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");

        // What is the magic number? 6
        // What is your guess? 4
        // Higher

        // Use the random class to generate a number between two others.
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        Console.WriteLine("A random number between 1 and 10 was generated:");
        Console.WriteLine(magicNumber);



        // Initialize the variable that is used in the loop.
        int guessNumber = 0;

        do
        {
            // Print screen requesting the user for a number.
            Console.Write("What is your guess? ");

            // Capture the number entered by the user (string)
            string strGuessNumber = Console.ReadLine();

            // Take the number entered and save it as int (variable pre initialized)
            guessNumber = int.Parse(strGuessNumber);

            // Do the verification to check if the user guessed
            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Higher");
            }

            // Add a line to improve readability
            Console.WriteLine("");

        } while (guessNumber != magicNumber);

        





    }
}