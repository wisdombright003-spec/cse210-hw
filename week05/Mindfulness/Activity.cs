public class Activity
{
    protected string _name;
    private string _description;
    protected int _duration;

    protected Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    protected void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(" ");

        Console.WriteLine(_description);
        Console.WriteLine(" ");

        Console.Write("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready.....");
        ShowSpinnner(5);
        
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        ShowSpinnner(3);
        Console.WriteLine($"You have completed {_duration} seconds of {_name} Activity");
        ShowSpinnner(2);

    }
    protected void ShowSpinnner(int seconds)
    {
        DateTime startTime =DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("-");
            animationStrings.Add("\\");

        while (DateTime.Now < endTime)  // This enable it to do what ever it is doing in a particular time frame
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(200); 
                Console.Write("\b \b");
            }   
        }
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500); 
            Console.Write("\b \b");
        }
    }

    protected void DotAnimation(int seconds = 5)
    {
        DateTime startTime =DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime) 
        {
            int dotsprinted = 0;

            // print up to 5 dots
            for (int i = 5; i > 0; i--)
            {
                if (DateTime.Now >= endTime)
                {
                    break;
                }
                Console.Write(".");
                dotsprinted++;
                Thread.Sleep(200); 
            }
            // Clean/erase the that were printed
            for (int i = 0; i < dotsprinted; i++)
            {
                Console.Write("\b \b");
                Thread.Sleep(100); 
            }
        }
    }
}