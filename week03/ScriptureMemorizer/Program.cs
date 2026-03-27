// Showing Creativity and Exceeding Requirements:
// Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.

using System;
using System.Runtime.CompilerServices;

class Program
{
    static Scripture Collection(int selection)
    {
        // 1. Included a collection of scriptures to select which one to memorize from a menu.
        List<Scripture> collection = new List<Scripture>();

        Reference refMoses1 = new Reference("Moses", 1, 39);
        string scrMoses1 = "39 For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.";
        Scripture Moses1 = new Scripture(refMoses1, scrMoses1);
        collection.Add(Moses1);

        Reference refMoses7 = new Reference("Moses", 7, 18);
        string scrMoses7 = "18 And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.";
        Scripture Moses7 = new Scripture(refMoses7, scrMoses7);
        collection.Add(Moses7);

        Reference refAbraham2 = new Reference("Abraham", 2, 9, 11);
        string scrAbraham2 = "9 And I will make of thee a great nation, and I will bless thee above measure, and make thy name great among all nations, and thou shalt be a blessing unto thy seed after thee, that in their hands they shall bear this ministry and Priesthood unto all nations; 10 And I will bless them through thy name; for as many as receive this Gospel shall be called after thy name, and shall be accounted thy seed, and shall rise up and bless thee, as their father; 11 And I will bless them that bless thee, and curse them that curse thee; and in thee(that is, in thy Priesthood) and in thy seed(that is, thy Priesthood), for I give unto thee a promise that this right shall continue in thee, and in thy seed after thee(that is to say, the literal seed, or the seed of the body) shall all the families of the earth be blessed, even with the blessings of the Gospel, which are the blessings of salvation, even of life eternal.";
        Scripture Abraham2 = new Scripture(refAbraham2, scrAbraham2);
        collection.Add(Abraham2);

        Reference refAbraham3 = new Reference("Abraham", 3, 22, 23);
        string scrAbraham3 = "22 Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; 23 And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.";
        Scripture Abraham3 = new Scripture(refAbraham3, scrAbraham3);
        collection.Add(Abraham3);

        return collection[selection];
    }

    static bool Memorize(Scripture scripture)
    {
        bool running = true;
        while (!scripture.IsCompletelyHidden() && running == true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            string enter = Console.ReadLine();

            if (enter == "")
            {
                // 2. Improved the random logic to avoid duplicates and improve the random logic.
                scripture.HideRandomWords(5);
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine(scripture.GetDisplayText());
                    enter = Console.ReadLine();
                }
            }

            else if (enter.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine("I N V A L I D   R E S P O N S E");
            }
        }

        return running;
    }

    static string Menu()
    {
        Console.WriteLine("Available scriptures:");
        Console.WriteLine("- Moses 1:39");
        Console.WriteLine("- Moses 7:18");
        Console.WriteLine("- Abraham 2:9–11");
        Console.WriteLine("- Abraham 3:22–23");
        Console.Write("\nPress 'Enter' to start memorizing one of these scriptures randomly!");
        Console.WriteLine("(Otherwise, type '0' to quit.)");
        string selection = Console.ReadLine();
        return selection;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the ScriptureMemorizer Project.");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nDoctrinal Mastery Scripture");
            Console.WriteLine("---------------------------");
            string option = Menu();

            if (option == "")
            {
                Random random = new Random();
                int selection = random.Next(0, 4);
                Scripture scripture = Collection(selection);
                running = Memorize(scripture);
            }
            else if (option == "0")
            {
                Console.WriteLine("\nE N D   O F   P R O G R A M !!!\n\n");
                break;
            }
            else
            {
                Console.WriteLine("Not valid, try again!");
            }
        }
    }
}