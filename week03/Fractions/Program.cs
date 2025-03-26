using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.WriteLine("");

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionValue());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionValue());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(3,4);
        Console.WriteLine(fraction2.GetFractionValue());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}