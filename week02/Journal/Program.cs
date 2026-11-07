// Exceeding Requirements: 
// 1. Added an automated file management system that detects existing journal files, 
//    lists them for easy selection, and automatically remembers the active filename 
//    for subsequent saves without repeatedly prompting the user.
// 2. Implemented CSV file formatting so journal entries can be opened and viewed cleanly in Excel.

using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal myjournal = new Journal();
        string currentfilename = "";

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

           choice = Console.ReadLine() ;  
           if (choice == "1")
            {
                Write(myjournal, promptGenerator);
            }

           else if (choice == "2")
            {
                myjournal.DisplayAll();
            }

           else if (choice == "3")
            {
                Save(myjournal, ref currentfilename);
            }

            else if (choice == "4")
            {
                Load( myjournal,  ref currentfilename);
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            
            else
            {
                 Console.WriteLine("Invalid option");
            }
        } 

        // entry write function
        static void Write(Journal myjournal, PromptGenerator promptGenerator)
        {
            string randomprompt = promptGenerator.GetRandomPrompt();


            Console.WriteLine(randomprompt);
            Console.Write("> ");
            string response = Console.ReadLine();

            DateTime theCurrentTime = DateTime.Now;
            string currentDate = theCurrentTime.ToString("yyyy-MM-dd HH:mm:ss");
            Entry newEntry = new Entry(currentDate, randomprompt, response);
            myjournal.AddEntry(newEntry);
            //myjournal.DisplayAll();
        }

        static void Save(Journal myjournal, ref string currentfilename)  // use ref to remember the filenamefor the next time 
        {
            string filename = "";

            // Check if it the first time 
            if (string.IsNullOrEmpty(currentfilename))
            {
                Console.Write("Name the file: ");
                currentfilename = Console.ReadLine() + ".csv";
                filename = currentfilename;
            }
            else
            {
                // Atomatically use the existing journal file
                filename = currentfilename;
            }
            // Save the journal to the selected file
            myjournal.SaveToFile(filename);
        }

        static void Load(Journal myjournal, ref string currentfilename)
        {
            while (string.IsNullOrWhiteSpace(currentfilename) || 
            !File.Exists(currentfilename)) // while the filename is empty or don't exit loop
            {
                Console.Write("Enter journal name: ");
                currentfilename = Console.ReadLine() + ".csv";
                if (!File.Exists(currentfilename))
                {
                    Console.WriteLine("File do not exist");
                }
            }
            List<Entry> savedEntries = myjournal.ReadFromFile(currentfilename);
            Console.WriteLine("Reading file........");
            foreach (Entry entry in savedEntries)
            {
                entry.Display();
            }
        }
    }
        
}