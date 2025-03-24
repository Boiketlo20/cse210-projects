using System;
using System.IO; 

public class CreatingTextFile
{public static void CreateFile()
{
    string fileName = "journal.txt";

    if (!File.Exists(fileName))
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This will be the first line in the file.");
        }
        Console.WriteLine("File created successfully.");
    }
    else
    {
        Console.WriteLine("File exists.");
    }
}
}
