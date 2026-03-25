// Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.

using System.Reflection.Metadata;

public class Scripture
{
    // V A R I A B L E S
    private Reference _reference;
    private List<Word> _words;


    // M E T H O D S
    public void HideRandomWords(int numberToHide)
    {
        // Generate a "Random" list with numberToHide numbers.
        Random random = new Random();
        // List<int> indexOfRandoms = new List<int>();

        // int i = 0;

        // while (indexOfRandoms.Count < numberToHide && indexOfRandoms.Count < _words.Count)
        // {
        //     int randNumber = random.Next(0, _words.Count);

        //     if (!indexOfRandoms.Contains(randNumber) && _words[i].IsHidden())
        //     {
        //         indexOfRandoms.Add(randNumber);
        //     }

        //     i += 1;
        // }


        // Creating a list with all positions where word is not hidden.
        List<int> notHidden = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                notHidden.Add(i);
            }
        }

        // Mix to generate the randoms
        for (int i = 0; i < notHidden.Count; i++)
        {
            int j = random.Next(i, notHidden.Count);
            (notHidden[i], notHidden[j]) = (notHidden[j], notHidden[i]);
        }

        // Assure that the hide numbers are always equal or less than the available.
        int countToHide = Math.Min(numberToHide, notHidden.Count);

        // Hide the positions matching the "Random" list.
        int position;
        for (int i = 0; i < countToHide; i++)
        {
            position = notHidden[i];
            _words[position].Hide();
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();

        string scripture = "";

        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }

        string displayScripture = $"\n{reference}\n{scripture}";

        return displayScripture;
    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = true;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                completelyHidden = false;
                break;
            }
        }
        return completelyHidden;
    }

    // C O N S T R U C T O R S    
    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach(string word in scripture.Split(' '))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
}
