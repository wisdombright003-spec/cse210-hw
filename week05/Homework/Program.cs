using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Wisdom Sunday", "Inheritance");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Joshua", "Math", "Section 7.3", "1-6");
        Console.WriteLine( assignment2.GetSummary());
        Console.WriteLine( assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Samuel", "War", "World war II");
        Console.WriteLine( assignment3.GetSummary());
        Console.WriteLine( assignment3.GetWritingInformation());
    }
}