// Entry: Represents a single journal entry.
public class Entry
{
    // public string _date;
    // public string _prompt;
    // public string _entry;

    // The public fields used for the TXT file are not working with JSON.
    // Change the class to start using properties, as I read these are taken by the JSON C# methods.

    public string Date { get; set; }
    public string Prompt { get; set; }
    public string EntryText { get; set; }

    public void Display()
    {
        // This function will be used for displaying the journal.
        // Console.WriteLine($"Date: { _date}\nPrompt: { _prompt}\nRecording: { _entry}\n");
        Console.WriteLine($"Date: {Date}\nPrompt: {Prompt}\nRecording: {EntryText}\n");
    }
}