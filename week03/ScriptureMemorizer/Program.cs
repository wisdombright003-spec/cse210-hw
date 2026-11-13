// Creativity beyond requirements:
// This program supports a library of scriptures,
// allows users to add new scriptures, and supports
// saving and loading scriptures from files.
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Reference reference = new  Reference("john",3, 12,112);
        //string text = "For God so loved the world, that he gave his only begotten Son...";
        //Scripture scripture = new Scripture(reference, text);
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();
        string filename = "library.txt";
        library.SaveToFile(filename);

        Console.WriteLine("WELCOME TO SCRIPTURE MEMORIZER");
        Console.WriteLine(" ");
        string choice = " ";
        while (choice != "4")
        {
            Console.WriteLine(" ");
            Console.WriteLine("1. Memorize a random scriptures");
            Console.WriteLine("2. Add a new scripture");
            Console.WriteLine("3. View all scriptures instore");
            Console.WriteLine("4. Exit");

            Console.WriteLine(" ");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();  
            if (choice == "1")
            {
                Scripture randomscripture = library.GetRandomScripture();
                scripture.ResetWords();
                MemorizeARandomScriptures(randomscripture);
            }
            else if (choice == "2")
            {
                AddScripture(library, filename);
            }
            else if (choice == "3")
            {
                Load(library, filename);
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            
        }

        static void MemorizeARandomScriptures(Scripture scripture)
        {
            while (true)
            {
                Console.WriteLine(scripture.GetScriptureDisplayText());
                Console.WriteLine(" ");
                Console.WriteLine("Press enter to continue or quit to exit ");
                string input = Console.ReadLine();
                if (scripture.IsCompletelyHidden()) //This checks whether every word has been hidden.
                {
                    break; 
                }
                if  (input == "quit")
                {
                   break;
                }
                scripture.HideRandomWord();
                Console.Clear();
            }

        }
        static void Load(ScriptureLibrary library, string filename)
        {
            List<Scripture> savedScriptures = library.ReadFromFile(filename);
            foreach (Scripture scriptures in savedScriptures)
            {
                Console.WriteLine(scriptures.GetScriptureDisplayText());
            }
        }

        static void AddScripture(ScriptureLibrary library, string filename)
        {
            Console.Write("Enter the book: ");
            string book = Console.ReadLine();

            Console.Write("Enter the chapter: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Enter the starting verse: ");
            int startingVerse = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending verse (or 0 if there is none): ");
            int endingVerse = int.Parse(Console.ReadLine());

            if (endingVerse < startingVerse)
            {
                endingVerse = 0;
            }

            Reference reference;

            if (endingVerse == 0)
            {
               reference = new Reference(book, chapter, startingVerse);
            }
            else
            {
               reference = new Reference(book, chapter, startingVerse, endingVerse);
            }

            Console.Write("Enter the scripture text: ");
            string text = Console.ReadLine();

            library.AddScripture(reference, text, filename);
        }



    }
} 