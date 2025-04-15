using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        //Display the main menu & display player info:
        //Call the following functions:
        //CreateGoal, ListGoalDetails, SaveGoal, LoadGoals, RecordEvents
        //Loop until quit
        LoadGoals();

        Console.WriteLine($"You have {_score} points");
        Console.WriteLine("");

        var choice = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select an option from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if(choice == "3")
            {
                SaveGoals();
            }
            else if(choice == "4")
            {
                LoadGoals();
                DisplayPlayerInfo();
            }
            else if(choice == "5")
            {
                if (_goals.Count > 0)
                {
                    RecordEvent();
                }
            }
            else if(choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice, try again!");
            }
        }
        while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        //Dislay the points
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        //List through the list of goals and display the names of the goals
        //(You need another function in the goal class!)
        //For example: 1.Go to bed on time
        //2. Do my homework
        Console.WriteLine("Your goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

    }

    public void ListGoalDetails()
    {
        //Loop through the list of goals and display 
        //the full details
        foreach (Goal goals in _goals)
        {
            string fullDetails = goals.GetDetailsString();
            Console.WriteLine($"{fullDetails}");
        }
    }

    public void CreateGoal()
    {
        //Ask the user what kind of goal they want to implement
        //Display a sub-menu to select a goal type
        //Ask for the name, description, and points
        //Ask more if they pick checklist goal
        //Create the object and add to the goal list
        var choice = "";
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("What type of gaol would you like to create?");
        choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a brief description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (choice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the amount of the bonus points for completing this goal? ");
            int bonus = int.Parse(Console.ReadLine()); 
            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        _goals.Add(newGoal);
        //Display main menu
        //Add the infomation to list
    }
        

    public void RecordEvent()
    {
        //Display a list of all of the goal names
        //Ask them to select a goal 
        //Call RecordEvent on the correct 
        //Update the score based on the points
        //Display current points 
        ListGoalNames();
        Console.WriteLine("Which goal did you complete?"); 
        int choice = int.Parse(Console.ReadLine());
        
        int index = choice - 1;
        Goal selectedGoal = _goals[index];
        int pointsEarned = selectedGoal.RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"Congratulations! You earned {pointsEarned} points for completing {selectedGoal.GetShortName()}.");
        Console.WriteLine($"Your total score is now {_score}.");

    }

    public void SaveGoals()
    {
        //Ask user for a file name
        //loop through the goals and convert each goal to a string and then
        //save the string.
        string filename = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score:{_score}");

            foreach (Goal goal in _goals)
            {
                string goalRepresentation = goal.GetStringRepresentation();
                outputFile.WriteLine(goalRepresentation);
            }
        }
        Console.WriteLine($"Goals saved to '{filename}'");
    }

    public void LoadGoals()
    {
        //Ask the user for a file name
        //Read each line of the file and split it up
        //Use the parts to re-create the Goal object 
        //Line no.1 - accumulated points
        //You can split up string by vertical bar
        //You're going to need to call some functions

        //Option 1 : Create some Set Functions
        //Option 2: Made a 2nd constructor for Simple goal and ChecklistGoal
        string filename = "goals.txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals found. Starting with empty goals.");
            _goals = new List<Goal>();
            _score = 0;
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = 0;

        foreach (string line in lines)
        {
            if (line.StartsWith("Score:"))
            {
                _score = int.Parse(line.Substring(6)); 
            }
            else if (!string.IsNullOrWhiteSpace(line))
            {
                string[] parts = line.Split(':');
                string goalType = parts[0];
                string goals = parts[1];
            
                Goal goal = CreateGoalFromData(goalType, goals);
                _goals.Add(goal);
            }
        }
        Console.WriteLine($"Goals loaded from '{filename}'");
    }

    private Goal CreateGoalFromData(string goalType, string goalData)
    {
        string[] dataParts = goalData.Split(','); 
    
        string name = dataParts[0];
        string description = dataParts[1];
        int points = int.Parse(dataParts[2]);

        switch (goalType)
        {
            case "SimpleGoal":
                bool isComplete = bool.Parse(dataParts[3]);
                var simpleGoal = new SimpleGoal(name, description, points);
                if (isComplete) simpleGoal.RecordEvent(); 
                return simpleGoal;

            case "EternalGoal":
                return new EternalGoal(name, description, points);

            case "ChecklistGoal":
                int target = int.Parse(dataParts[3]);
                int bonus = int.Parse(dataParts[4]);
                int completed = int.Parse(dataParts[5]);
                var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                for (int i = 0; i < completed; i++) checklistGoal.RecordEvent(); 
                return checklistGoal;

            default:
                return null; 
        }
    }
    
}