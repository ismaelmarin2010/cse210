using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // Variables:
    public List<Entry> _entries = new List<Entry>();


    // Funtions or Methods
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Just iterate on the Journal executing the method for entry.Display()
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // // Open / Create the file indicated by the user
        // using (StreamWriter outputFile = new StreamWriter(file))
        // {
        //     // Save the Journal into the file using the format shown
        //     foreach (Entry item in _entries)
        //     {
        //         outputFile.WriteLine($"{item._date}|{item._prompt}|{item._entry}");
        //     }

        //     // 2. Also, it displays the full file path when saving/loading
        //     Console.WriteLine(Directory.GetCurrentDirectory());
        // }



        // 4. Moreover, switched from .txt to .json for better flow of the program.
        // Create the variable and save there the entire Journal serialized, then save the file.
        string jsonDatabase = JsonSerializer.Serialize(_entries);
        File.WriteAllText(file, jsonDatabase);

        // 2. Also, it displays the full file path when saving/loading
        Console.WriteLine(Directory.GetCurrentDirectory());

    }

    public void LoadFromFile(string file)
    {
        // // 2. Also, it displays the full file path when saving/loading
        // Console.WriteLine($"Looking for file at: {Path.GetFullPath(file)}");

        // // Clears the Journal variable to load there the content of the file
        // _entries.Clear();

        // // Create the temp variable to work with the file.
        // string[] lines = System.IO.File.ReadAllLines(file);

        // // Read the file, save in the temp variable and then tranfer it to the Journal
        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split("|");

        //     Entry fromFile = new Entry();

        //     fromFile._date = parts[0];
        //     fromFile._prompt = parts[1];
        //     fromFile._entry = parts[2];

        //     _entries.Add(fromFile);

        // }

        // 2. Also, it displays the full file path when saving/loading
        Console.WriteLine($"Looking for file at: {Path.GetFullPath(file)}");

        // 4. Moreover, switched from .txt to .json for better flow of the program.

        // From the file, create a long string with all its content.
        string fileContent = File.ReadAllText(file);

        // Create a new list with format Entry, then use the C# method Deserialize to convert the string into a list of Entry objects.
        List<Entry> listOfEntriesFromFile = JsonSerializer.Deserialize<List<Entry>>(fileContent);

        // If the list is not null, replace the Journal with the values read from the file.
        if (listOfEntriesFromFile != null)
        {
            // The entire Journal is replaced with the values from the file, no need to clear before.
            _entries = listOfEntriesFromFile;
        }
    }
}