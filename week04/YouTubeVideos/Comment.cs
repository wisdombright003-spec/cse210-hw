public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string commenters_name, string text)
    {
        _commenterName = commenters_name;
        _text = text;
    }

    public string GetComment()
    {
        return $"@{_commenterName}: {_text}";
    } 
}