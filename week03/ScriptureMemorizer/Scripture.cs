public class Scripture
{
    List<Word> _words;  // created a variable for a list of words
    private Reference _reference; 

    public Scripture(Reference reference, string text)
    {
        _words = new List<Word>(); // list of word object
        _reference = reference;

         // calling the createword methods
        CreateWords(text);
    }
    private void CreateWords(string text)  // this method go through the text one by one turning them into Word object and adding them into the word object list 
    {
        string[] Words = text.Split(' ');
        foreach (string wordText in Words)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }

    }

    // This method is responsible for hiding random word 
    public void HideRandomWord()
    {
        List<Word> visibleWords = new List<Word>(); // we create a temporary list for only visible word list ishidden false
        foreach (Word word in _words) // Go through the _word list each of them and add the once that ishidden is false to the visible list
        {
            if (word.GetIsHidden() == false)
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count == 0)  // if there is no longer any visible word it return
        {
            return;
        }
        // Generate a random index within the visibleWords list,
        // use that index to select a Word object, and hide the selected word
        Random random = new Random();
        int index = random.Next(0, visibleWords.Count);

        Word selectedWord = visibleWords[index]; //This retrieves the Word object at the randomly selected position and stores it in selectedWord.
        selectedWord.Hide();  
    }

    public string GetScriptureDisplayText()
    {
        string refere_ence = _reference.DisplayReferenceText()+ ",";
        foreach (Word word in _words)  // This allows us to examine every Word object, one at a time.
        {
             refere_ence += word.GetDisplayText() + " ";
        }
        return refere_ence;
    }

    public bool IsCompletelyHidden() // this method returns true if all words are hidden
    {
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}