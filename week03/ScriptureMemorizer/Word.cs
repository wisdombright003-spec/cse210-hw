public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text) // with this constructor everytime you create a new Word object, it attribute start as false
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()  // this method turn ishidden to true
    {
        _isHidden = true;
    }

    public bool GetIsHidden() // this method gets the state of the state of ishidden
    {
        return _isHidden;
    }

    public string GetDisplayText() // if any word is hidden it returns "_" if not the text
    {
        if (_isHidden == true )
        {
            return "__" ;
        }
        else
        {
            return _text;
        }
    } 
}