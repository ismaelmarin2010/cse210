public class Comment
{
    // V A R I A B L E S
    private string _name;
    private string _text;


    // C O N S T R U C T O R S 
    public Comment(string name, string comment)
    {
        _name = name;
        _text = comment;
    }


    // M E T H O D S
    public void DisplayText()
    {
        Console.WriteLine($"'{_name}' wrote: {_text}");
    }
}