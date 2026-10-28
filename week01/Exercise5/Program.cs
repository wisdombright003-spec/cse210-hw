using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName(); 
        int userNum = PromptUserNumber();
        int square = squareNumbeer(userNum);
        DisplayResult(name, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
       Console.Write("Please enter your name: ");
       string userName = Console.ReadLine();
       return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int userNum = int.Parse(num);
        return userNum;
        
    }

    static int squareNumbeer(int userNum)
    {
       int square = (int)Math.Pow(userNum, 2);
       return square;
    }
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}