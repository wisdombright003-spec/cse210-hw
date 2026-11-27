public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random randomGenerator = new Random();
    private List<string> _remainingQustions;


    public ReflectingActivity(string name, string description, int duration): base(name, description, duration)
    {
        _prompts = new List<string>(); 
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Thnk of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        _remainingQustions = new List<string>(_questions); //Create a new list let it contain the original list containing all questions
    }

    public void RunReflect()
    {
        DisplayStartingMessage();
        DateTime startTime =DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            
            DisplayPrompt(GetRandomPrompt());
            Console.WriteLine();

            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder. on each of the following questions as they related to this experience.");
            Console.Write("Loading");
            DotAnimation(); Console.WriteLine();
            Console.Clear();
            if (_remainingQustions.Count == 0)
            {
                _remainingQustions = new List<string>(_questions); // refill the question list when it is empty
            }

            // Only one timed loop for the question
            while (DateTime.Now < endTime)
            {
                string question = GetRandomQuestion();
                if (question == null)
                {
                    break;
                }
                DisplayQuestion(question);
                ShowSpinnner(5); Console.WriteLine();
                Console.WriteLine(" ");
            }
        }
        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        //Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Count);
        return $"--{_prompts[index]}--";
    }
    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }

    private string GetRandomQuestion()
    {
        if (_remainingQustions.Count == 0) //check how many questions are left then stop when there is none
        {
            return null;
        }
        int index = randomGenerator.Next(0, _remainingQustions.Count);
        string question = _remainingQustions[index];

        _remainingQustions.RemoveAt(index); // This remove the question at the selected index from the list
        return question;
            
    }

    public void DisplayQuestion(string question)
    {
        Console.Write($"< {question} ");
    }


}