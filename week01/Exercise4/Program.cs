using System;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // this forms the list
        List<int> numbers = new List<int>();
        
        
        while (true)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            float response = float.Parse(number);
            if (response == 0)
            {
                break;
            }
            // this sends the number to form the list
            numbers.Add((int)response);  
            
        } 
        // to get the len of the set of numbers 
        int length = numbers.Count;
        
        //Console.WriteLine(string.Join(", ", numbers)); to print the list of the number
        // sum total of the set 
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        } 
        Console.WriteLine($"The sum is: {total}");

        float average = (float)total / length;
        Console.WriteLine($"Average of the set is {average}");

        // To find the max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        // lowest positive number
        int? smallestPositive = null; //This means we haven't stored any num yet,
                          // int? is a shorthand for nyllable: an integer that can also hold null, A regular int must,
                          // always have a value (it defaults to 0). Adding ? lets it represent "no value
        foreach (int num in numbers)// Visit each number in the set, one at a time
        {
            if (num > 0)// skip anyyhing. that isn't positive
            {
                if (smallestPositive == null || num < smallestPositive)
                // (smallestPositive == null) nothing has been stored yet so the first positive number automatically win
                // (num < smallestPositive number) This number is smaller than the best one so far
                {
                    smallestPositive = num;
                }
            }
        }
        Console.WriteLine($"Smallest positive number is {smallestPositive}");
        // to sort in asending order
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int verticallyArranged in numbers)
        {
            Console.WriteLine(verticallyArranged);
        }
    
        

    }
}