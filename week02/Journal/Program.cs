// Showing Creativity and Exceeding Requirements:
// 1. The program enforces the .json extension for reading and saving
// 2. Also, it displays the full file path when saving/loading
// 3. Additionally to the date, the program shows HH:mm:ss, useful when using several entries per day
// 4. Moreover, switched from .txt to .json for better flow of the program

using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // This is just the menu...
        static int Menu()
        {
            Console.WriteLine("\nMENU\n----\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            int selection = int.Parse(Console.ReadLine());
            return selection;
        }

        // This function receives a Journal variable
        void Write(Journal journal)
        {
            // Capture the date for the record
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Generate and display a new random prompt
            PromptGenerator generator = new PromptGenerator();
            string prompt = generator.GetRandomPrompt();
            Console.WriteLine(prompt);

            // Save the user's response into the entry variable
            string entry = Console.ReadLine();

            // Create the variable newLine of type "Entry" to save everything
            Entry newLine = new Entry
            {
                // Had to change this after switching from txt to json
                // _date = date,
                // _prompt = prompt,
                // _entry = entry

                Date = date,
                Prompt = prompt,
                EntryText = entry
            };

            // Add the new "Entry" to the Journal variable
            journal.AddEntry(newLine);
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("-------------------------------");

        Journal journal = new Journal();
        bool running = true;

        //////////////////////

        while (running)
        {
            int option = Menu();

            if (option == 1)
            {
                Write(journal);
                Console.WriteLine("-------------------------------------\n");
            }

            else if (option == 2)
            {
                Console.WriteLine("\nThis is your Journal so far:");
                Console.WriteLine("----------------------------\n");
                journal.DisplayAll();
                Console.WriteLine("----------------------------\n");
            }

            else if (option == 3)
            {
                Console.WriteLine("\nIndicate the name of your file:");
                string file = Console.ReadLine().ToLower();

                // 1. The program enforces the .json extension for reading and saving
                // 4. Moreover, switched from .txt to .json for better flow of the program
                if (!file.EndsWith(".json"))
                {
                    file += ".json";
                }
                journal.LoadFromFile(file);
                // 2. Also, it displays the full file path when saving/loading
                Console.WriteLine("Your Journal was successfully loaded.");
                Console.WriteLine("-------------------------------------\n");
            }

            else if (option == 4)
            {
                Console.WriteLine("\nIndicate the name of your file:");
                string file = Console.ReadLine().ToLower();

                // 1. The program enforces the .json extension for reading and saving
                // 4. Moreover, switched from .txt to .json for better flow of the program
                if (!file.EndsWith(".json"))
                {
                    file += ".json";
                }
                // 2. Also, it displays the full file path when saving/loading
                Console.WriteLine("Your Journal was successfully saved:");
                journal.SaveToFile(file);
                Console.WriteLine("-------------------------------------\n");
            }

            else if (option == 5)
            {
                Console.WriteLine("You ended the program\n\n\n");
                running = false;
            }
        }
    }
}