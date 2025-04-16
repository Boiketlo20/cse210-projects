using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a Running, Biking, and Swimming event object and put them in the same list.
        //Using a loop, get the activity summary and display it for each activity.
        List<Activity> activities = new List<Activity>();

        RunningActivity runningActivity = new RunningActivity("16 April 2025", 30, 5);

        BikingActivity bikingActivity = new BikingActivity("15 May 2025", 45, 20);

        SwimmingActivity swimmingActivity = new SwimmingActivity("21 May 2025", 60, 40);

        activities.Add(runningActivity);
        activities.Add(bikingActivity);
        activities.Add(swimmingActivity);

        Console.WriteLine("Exercises tracked: ");
        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine($" {summary}");
        }
    }
}