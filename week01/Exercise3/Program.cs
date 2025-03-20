using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Try guessing a number");
        Random randomGen = new Random();
        int randNumber = randomGen.Next(1,101);

        Console.Write("What is your number? ");
        string guessNumber = Console.ReadLine();
        int number = int.Parse(guessNumber);

        while (randNumber != number)
        {

            if (randNumber < number)
            {
                Console.WriteLine("Lower");
            }
            else if (randNumber > number)
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your number? ");
            guessNumber = Console.ReadLine();
            number = int.Parse(guessNumber);
        }
        Console.WriteLine("You guessed it right!!");
    }
}

      