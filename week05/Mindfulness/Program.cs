using System;

class Program
{
    static int Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        int selection = int.Parse(Console.ReadLine());
        return selection;
    }

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            int option = Menu();

            if (option == 1)
            {
                Console.Clear();
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (option == 2)
            {
                Console.Clear();
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (option == 3)
            {
                Console.Clear();
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (option == 4)
            {
                running = false;
            }
        }
    }
}