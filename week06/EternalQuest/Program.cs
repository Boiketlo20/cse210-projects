using System;

class Program
{
    static void Main(string[] args)
    {
        //All we are going to do here is create a GoalManager object
        //Then call the Start() function on that object
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}