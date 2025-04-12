using System;
using System.Diagnostics.Contracts;
using System.Runtime.ConstrainedExecution;
using System.Security;

public class Activity{
    private string _name;
    private string _description; //Do I have to change these to protected? If i really need them, cant I then create Getters?
    private int _duration;

    public Activity(string name, string description)
    {
        //Initialise _name, _description and _duration
        _name = name;
        _description = description;
    }

    protected int PromptForDuration()
    {
        Console.Write("How long (in seconds) would you like your session? ");
        int duration = int.Parse(Console.ReadLine());
       return duration;
    }

    public void DisplayStartingMessage()
    {
       //You're going to have to clear the screen 
       //Welcome message
       //Prompt for the duration
       //ShowSpinner
       Console.Clear();
       Console.WriteLine($"Welcome to the {_name} Activity");                           
       Console.WriteLine("");
       Console.WriteLine(_description);
       Console.WriteLine("");
       _duration = PromptForDuration();
       Console.WriteLine("Get ready...");
       ShowSpinner(5); 
       Console.WriteLine("");
    }

    public int GetDuration()
    {
        return _duration;
    }

      public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayEndingMessage()
    {
        //Show ending message
        //ShowSpinner
        //Console.clear
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity");
        ShowSpinner(10);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        //Video
        // Spiner pattern : |/-\|/-\|

        List<string> animation = new List<string>()
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\", "|"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        //For loop that counts down
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
} 