using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");

        // Compute the sum, or total, of the numbers in the list.

        // Compute the average of the numbers in the list.

        // Find the maximum, or largest, number in the list.

        // The following shows the expected output:

        // Enter a list of numbers, type 0 when finished.
        // Enter number: 18
        // Enter number: 36
        // Enter number: 2
        // Enter number: 48
        // Enter number: 6
        // Enter number: 12
        // Enter number: 9
        // Enter number: 0
        // The sum is: 131
        // The average is: 18.714285714285715
        // The largest number is: 48

        // Print the title of the program.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create the list that will hold the numbers entered by the user:
        List<int> numbers = new List<int>();

        // Initialize the variable that is used in the loop.
        int number = 1;

        // Request the numbers and save them into a list.
        while (number != 0)
        {
            // Print screen requesting the user for a number.
            Console.Write("Enter number: ");

            // Capture the number entered by the user (string)
            string strNumber = Console.ReadLine();

            // Take the number entered and save it as int (variable pre initialized)
            number = int.Parse(strNumber);

            // Save the int number in the list if not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Iterate the list, sum the numbers, then print it.
        int sum = 0;
        int largest = 0;
        foreach (int n in numbers)
        {
            sum += n;
            
            // Save the lastest
            if (n > largest)
            {
                largest = n;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        // Count the elements, then divide and display the avg
        int total = numbers.Count;
        int avg = sum / total;
        Console.WriteLine($"The average is: {avg}");

        Console.WriteLine($"The largest number is: {largest}"); 

        Console.WriteLine("");
    }
}