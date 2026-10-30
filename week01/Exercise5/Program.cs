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
    // This function just print a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    // This function ask the user for a name annd returns it to whosoever ask of it
    static string PromptUserName()
    {
       Console.Write("Please enter your name: ");
       string userName = Console.ReadLine();
       return userName;
    }
    // This function ask for a number and reurns the number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int userNum = int.Parse(num);
        return userNum;
    }
    
    // This function finds the square of the user's number
    static int squareNumbeer(int userNum)
    {
       int square = (int)Math.Pow(userNum, 2);
       return square;
    }
    // This function displays the user name and the square of the user number
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}