using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        //fraction3.SetTop(3);
       // fraction3.SetButtom(4);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDesimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDesimalValue());
    }
}