using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"{letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard, and you will succeed next time.");
        }
    
    }
}