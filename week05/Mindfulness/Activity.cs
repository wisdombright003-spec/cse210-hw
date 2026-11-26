public class Activity
{
    protected string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
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
    public void DisplayEndingMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        ShowSpinnner(3);
        Console.WriteLine($"You have completed {_duration} seconds of {_name} Activity");
        ShowSpinnner(2);

    }
    public void ShowSpinnner(int seconds)
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
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }
    }
    protected void ShowBreathingAnimation(bool breatheIn)
    {
        int size = breatheIn ? 1 : 10;
        int end = breatheIn ? 10 : 1;
        int step = breatheIn ? 1 : -1;

        for (int i = size, count = 0;
            breatheIn ? i <= end : i >= end;
            i += step, count++)
        {
            Console.Write("\r" + new string('O', i).PadRight(10));
            Thread.Sleep(100 + count * 70);
        }

        Console.WriteLine();
    }

    public void DotAnimation(int seconds = 5)
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