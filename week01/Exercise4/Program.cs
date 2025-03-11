using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();

        int listNumber = -1; 

        while (listNumber != 0)
        {
            Console.WriteLine("Enter a number ");
            string number = Console.ReadLine();
            listNumber = int.Parse(number); 

            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            }
            
        }
        
        int total = 0;
        Console.WriteLine(numbers.Count);
        foreach (int value in numbers)
        {
            total = total + value;
        }

        float average = ((float)total)/numbers.Count;

        int largest = -1;
        foreach (var value in numbers)
        {
            if (value > largest) 
            {
                largest = value;
            }
        
        }

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest: {largest}");
    }
}