// Keeps track of a single word and whether it is shown or hidden.
public class Word
{
    // V A R I A B L E S
    private string _text;
    private bool _isHidden;


    // M E T H O D S
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            int wordLength = _text.Length;
            string hiddenWord = "";
            for (int i = 0; i < wordLength; i++)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }

        else
        {
            return _text;
        }
    }
    

    // C O N S T R U C T O R S
    
    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }
}