public class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int _endingVerse;


    public Reference(string book, int chapter, int startingVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
    }

    public Reference(string book, int chapter, int startingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endingVerse = startingVerse;
    }

    public string DisplayReferenceText()
    {
        if (_endingVerse == _startingVerse)
        {
            return $"{_book} {_chapter}:{_startingVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startingVerse}-{_endingVerse}";
        }
    }

}