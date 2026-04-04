public class Video
{
    // V A R I A B L E S
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;


    // C O N S T R U C T O R S 
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }


    // M E T H O D S
    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }
    private int GetNumberOfComments()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Lenght (in seconds): {_length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments Below:");
        for (int i = 0; i < _comments.Count; i++)
        {
            _comments[i].DisplayText();
        }
        Console.WriteLine("\n");
    }
}