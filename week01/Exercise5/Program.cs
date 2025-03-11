using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favourite number: ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);

        return favNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int number = userNumber * userNumber;

        return number; 
    }

    static void DisplayResult(string name, int number)
    {

        Console.WriteLine($"{name}, the square of your number is {number}");
    }
    
}