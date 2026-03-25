// Keeps track of the book, chapter, and verse information.
public class Reference
{
    // V A R I A B L E S
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // M E T H O D S
    public string GetDisplayText()
    {
        string displayReference;

        if (_endVerse == 0)
        {
            displayReference = $"{_book} {_chapter}:{_verse}";
        }

        else
        {
            displayReference = $"{_book} {_chapter}:{_verse} - {_endVerse}";
        }

        return displayReference;
    }


    // C O N S T R U C T O R S
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
}



