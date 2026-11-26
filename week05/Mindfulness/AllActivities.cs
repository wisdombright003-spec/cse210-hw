public class AllActivities
{
    public void Main()
    {
        DateTime startTime =DateTime.Now;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("More option:");
            Console.WriteLine("  1. Start breathiing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View stored listing activity");
            Console.WriteLine("  5. Quit");
            Console.WriteLine();
            Console.Write("Select a choice the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Breathe();
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                Reflect();
                Console.WriteLine();
            }
            else if (choice == "3")
            {
                Listing();
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                DisplaySavedAnswers();
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        DateTime endTime = DateTime.Now;
        TimeSpan totalTime = endTime - startTime;
        Console.WriteLine($"Total time spent: {totalTime.Minutes} minutes and {totalTime.Seconds} seconds.");
    }


     public void Breathe()
    {
        BreathingActivity breathe = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 60);
        breathe.RunBreathe();
    }

     public void Reflect()
    {
        ReflectingActivity reflect = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60);
        reflect.RunReflect();
    }

     public void Listing()
    {
        ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60);
        listing.RunListing();
    }

    public void DisplaySavedAnswers()
    {
        ListingActivity listing = new ListingActivity("Listing","Display saved answers",0);

        listing.ReadFromFile();
        Console.Write("Press enter to continue ");
        Console.ReadLine();
    }
}