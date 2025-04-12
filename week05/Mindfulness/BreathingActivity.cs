using System;
using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {
        //Initialises name and description
    }

    public void Run()
    {
        //Display starting and ending message
        //Have the user breathe in for 5 seconds
        //Have the user breathe out for 5 seconds
        //You will have to displaythe breathe in and breathe out messages and show thw spinner
        //There'll be a loop

        //I want to have to repeat this for the duration(loop)

        int breathingCycle = 5;
        int cycle = GetDuration() / (breathingCycle * 2);

        for(int i= 0 ; i < cycle; i++)
        {
            Console.Write(" breathe in...");
            ShowCountDown(breathingCycle);
            Console.Write(" breathe out...");
            ShowCountDown(breathingCycle);
        }
    }
}