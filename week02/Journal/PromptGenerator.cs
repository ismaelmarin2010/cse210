public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "If today had a movie title, what would it be and why?",
        "What is one small thing today that made you smile more than it should have?",
        "What mistake did you make today that future-you will laugh about?",
        "If your mood today were a weather forecast, what would it be?",
        "What is something you did today that your past self would be proud of?",
        "What random thought kept popping into your head today?",
        "If you had to give today a score out of 10, what would it be and why?",
        "What is one thing you avoided today that you probably shouldn't have?",
        "What moment today felt like a “main character” scene?",
        "When did you feel closest to God today, and what were you doing?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}