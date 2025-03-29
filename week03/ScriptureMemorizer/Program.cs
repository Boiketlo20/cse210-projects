using System;

class Program
{
    static void Main(string[] args)
    {
        //loop for our program
        //Display things
        //Hide
        //Check if we need to quit
        //Only use functions is the scripture class

        Scripture scripture = new Scripture(new Reference("Nephi", 1, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        bool firstDisplay = true;  // Track if it's the first display

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden() == true)
            break;

            if (firstDisplay)
            {
                Console.WriteLine("Press Enter to start hiding words.");
                firstDisplay = false; 
            }
            else
            {
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            }

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            break;

            scripture.HideRandomWords(4);  
        }

    }
}