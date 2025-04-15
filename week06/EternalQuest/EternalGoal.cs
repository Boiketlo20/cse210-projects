using System;
using System.Security.Cryptography;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        //return the point value associated with recording the event
        return _points;
    }

    public override bool IsComplete()
    {
        //It is eternal, therefore never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}