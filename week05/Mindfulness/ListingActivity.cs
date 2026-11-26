public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;
    List<string> answers= new List<string>();

    public ListingActivity(string name, string description, int duration): base(name, description, duration)
    {
        _prompts = new List<string>();
        _prompts.Add("Who are the people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        answers = new List<string>();
    }
    public void RunListing()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("List as many response as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5); Console.WriteLine();
        GetListFromUser();

        _count = _prompts.Count;
        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();
        SaveToFile();

    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Count);
        Console.WriteLine($"--{_prompts[index]}--");
    }

    public List<string> GetListFromUser()
    {
       // List<string> answers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
       {
            Console.Write("> ");
            string answer = Console.ReadLine();
            answers.Add(answer);
       }
       return answers;
    }

    public void SaveToFile()
    { 
       string filename = "Listing_activity.txt";
       using (StreamWriter outputFile = new StreamWriter(filename , true))
        {
            // visit each Entry object on the list
            foreach (string x in answers)
            {
                outputFile.WriteLine(x);
            }
        }

    }

    public  void ReadFromFile()
    {
        string filename = "Listing_activity.txt";
        answers.Clear();

        // Read all file lines into an arry of strings.
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string answer in lines)
        {
            Console.WriteLine(answer);
        }
    }

}