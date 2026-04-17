public class GoalManager
{
    // VARIABLES
    private List<Goal> _goals;
    private int _score;

    // GETTERS AND SETTERS
    private int GetLevel()
    {
        return (_score / 1000) + 1;
    }


    // CONSTRUCTORS
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // METHODS
    private void CheckAchievements()
    {
        if (_score >= 1000)
            Console.WriteLine("Champion Badge unlocked!");
        else if (_score >= 500)
            Console.WriteLine("Dedicated Badge unlocked!");
        else if (_score >= 100)
            Console.WriteLine("Starter Badge unlocked!");
    }
    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nYou have {_score} points");
            CheckAchievements();
            Console.WriteLine($"You are Level {GetLevel()}\n");
            

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create new Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");

            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                CreateGoal();
            }
            else if (option == "2")
            {
                ListGoalDetails();
            }
            else if (option == "3")
            {
                SaveGoals();
            }
            else if (option == "4")
            {
                LoadGoals();
            }
            else if (option == "5")
            {
                RecordEvent();
            }
            else if (option == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid option, try again.\n\n");
            }
        }
    }

    // public void DisplayPlayerInfo()
    // {
    //     Console.WriteLine($"Score: {_score}");
    // }

    // public void ListGoalNames()
    // {
    //     for (int i = 0; i < _goals.Count; i++)
    //     {
    //         Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
    //     }
    // }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have not yet set goals. Go ahead and start changing your path!");
        }
        else
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count) // Double check that the index is within range
        {
            Goal goal = _goals[index];

            bool wasComplete = goal.IsComplete();
            
            goal.RecordEvent();

            _score += goal.GetPoints();

            bool isNowComplete = goal.IsComplete();

            if (!wasComplete && isNowComplete && goal is ChecklistGoal checklist)
            {
                _score += checklist.GetBonus();
            }
        }
        else
        {
            Console.WriteLine("That is not a valid option, try again.\n\n");
        }
    }

    // private int checklistBonus(ChecklistGoal goal)
    // {
    //     return goal.GetBonus();
    // }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string option = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (option == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (option == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (option == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("That is not a valid option, try again.\n\n");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            // Save score FIRST
            output.WriteLine($"Score|{_score}");

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        // Improved with validations against errors

        if (!File.Exists(filename)) // Avoid crash if file does not exists
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = 0;

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) // Avoid splitting issues..
                continue;

            string[] parts = line.Split('|');

            if (parts.Length < 2) // Avoid malfromed data.
            {
                continue;
            }

            string type = parts[0];

            if (type == "Score")  // Take out the score
            {
                _score = int.Parse(parts[1]);
                continue;
            }

            if (type == "SimpleGoal")
            {
                bool isComplete = parts.Length > 4 && bool.Parse(parts[4]);

                _goals.Add(new SimpleGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    isComplete
                ));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3])
                ));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }
        RecalculateScore();
    }

    private void RecalculateScore()
    {
        _score = 0;

        foreach (Goal goal in _goals)
        {
            if (goal is SimpleGoal simpleGoal)
            {
                if (simpleGoal.IsComplete())
                {
                    _score += simpleGoal.GetPoints();
                }
            }
            else if (goal is EternalGoal eternalGoal)
            {
                // Eternal goals are not stored historically in score
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                // Each completion cycle contributes points
                _score += checklistGoal.GetPoints() * checklistGoal.GetCompletedCount();

                if (checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus();
                }
            }
        }
    }


}