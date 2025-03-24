using System;

class Program
{
    static void Main(string[] args)
    {
        CreatingTextFile.CreateFile();
        Console.WriteLine("Journal created successfully.");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {newEntry._promptText}");
                    Console.Write("Your response: ");
                    newEntry._entryText = Console.ReadLine();
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2":
                    // Display the journal
                    journal.DisplayAll();
                    break;

                case "3":
                    // Save the journal to a file
                    Console.Write("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "4":
                    // Load the journal from a file
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "5":
                    // Exit the program
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }
}