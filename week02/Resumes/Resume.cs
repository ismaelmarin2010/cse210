public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs History:");

        foreach (Job item in _jobs)
        {
            item.Display();
        }
    }
}