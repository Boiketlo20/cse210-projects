using System;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        //If we previously were not complete, then mark complete and return points
        //What if we previously were complete?
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        //Return back whether this goal is complete or not
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}