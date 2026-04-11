public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        BreathExercise(base.GetDuration());
        base.DisplayEndingMessage();
        Console.Clear();
    }

    public void BreathExercise(int time)
    {
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int counter = 2;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.WriteLine("Breath in...");
            base.ShowCountDown(counter);

            Console.WriteLine("Now breath out...");
            base.ShowCountDown(counter + 1);

            counter += 1;
        }
    }
}