using System.Xml.Linq;

public class ScriptureLibrary
{
    private List<Scripture> _scripturesLibrary;

    private Random _random;
    public ScriptureLibrary()
    {
        _scripturesLibrary= new List<Scripture>();
        _random = new Random();

        _scripturesLibrary.Add(new Scripture(
            new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son..."));
            
        _scripturesLibrary.Add(new Scripture(
            new Reference("Proverbs", 3, 5), "Trust in the Lord with all thine heart..." ));

        _scripturesLibrary.Add(new Scripture(
            new Reference("Philippians", 4, 13),"I can do all things through Christ which strengtheneth me." ));
        
    }
    public Scripture GetRandomScripture()
    {
        int index = _random.Next(0, _scripturesLibrary.Count);

        return _scripturesLibrary[index];
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Scripture scripture in _scripturesLibrary)
            {
                outputFile.WriteLine(scripture.GetScriptureDisplayText());
            }
            Console.WriteLine($"File saved at: {Path.GetFullPath(filename )}");
        }
    }

    public  List<Scripture> ReadFromFile(string filename)
    {
         _scripturesLibrary.Clear();

        // Read all file lines into an arry of strings.
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            // Seperate the reference from the text
           string[] parts = line.Split(',');

           string text = parts[1]; // the text part 
           
           // seperate the book from the chapter and verses
           string[] referenceparts = parts[0].Split(' ');

           string book = referenceparts[0];

            // seperate the chapter from the verses
            string[] chapterVerse = referenceparts[1].Split(':');
            
            int chapter = int.Parse(chapterVerse[0]);
            

            // check if whether the reference has an ending verse
            if (chapterVerse[1].Contains('-'))
            {
                string[] verses = chapterVerse[1].Split('-');

                int startingVerse = int.Parse(verses[0]);
                int endingVerse = int.Parse(verses[0]);

                Reference reference = new Reference(book, chapter, startingVerse, endingVerse);
                Scripture scripture = new Scripture(reference, text);
                _scripturesLibrary.Add(scripture);
            }
            else
            {
                int verse = int.Parse(chapterVerse[1]);
                Reference reference = new Reference(book, chapter, verse);
                Scripture scripture = new Scripture(reference, text);
                _scripturesLibrary.Add(scripture);

            }
        
        }
        return _scripturesLibrary;
    }

    public void AddScripture(Reference reference, string text, string filename)
    {
        Scripture scripture = new Scripture(reference, text);
        _scripturesLibrary.Add(scripture);
        SaveToFile(filename);
    }
}