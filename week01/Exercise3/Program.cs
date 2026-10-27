using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    { 
        //Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1,100);
        //Console.WriteLine(number);

        //int guess = -1; // This guarantee the while loop triggers
        //int guessCount = 0;

        bool playAgain = true;
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);

            int guess = -1; // This guarantee the while loop triggers
            int guessCount = 0;
            while (guess != number) 
        {
            Console.Write("What is the magic number? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);
            guessCount ++;

            if (guess == number )
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses");
                
                Console.Write("Do you wannt to play again? (yes/no):");
                string response = Console.ReadLine();
                playAgain = response.ToLower() == "yes";
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }    
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

        }
        }


    }
}