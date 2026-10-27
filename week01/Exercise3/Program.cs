using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // the question 
        Console.Write("What is your grade percentage "); 

        // input statement
        string answer = Console.ReadLine();

        // change to digit
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "B";
        }
        else if (percent >= 50)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+, -, or none)
        string sign = "";
        int lastDigit = percent % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <3 )
        {
            sign = "-";
        }

        // special once for no A+, no f+ or f-
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        
        Console.WriteLine($"Your grade is {sign}{letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed");
        }

        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}