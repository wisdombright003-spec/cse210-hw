public class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments;
    


    public Video(string title, string author, int lenght)
    {
        _comments = new List<Comment>();
        _title = title;
        _author = author;
        _length = lenght;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public int NumberOfComment()
    {
        return _comments.Count;
    }

    public void DisplayVid()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_length}s");
        Console.WriteLine($"Comment: {NumberOfComment()}");
    }

    public void DisplayComment()
    {
        Console.WriteLine("💬💬💬");
        foreach (Comment comment in _comments)
        {
            //Console.WriteLine("💬💬💬");
            Console.WriteLine(comment.GetComment());
        }
    }

}