using System;
using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal
{
    private int _amountCompleted ;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted ++;
        int points = _points;

        if (_amountCompleted >= _target)
        {
           return _points + _bonus;
        }
        else
        {
            return _points;
        }


    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string completionMarker = "[ ]";
        if (IsComplete()) 
        {
            completionMarker = "[X]";
        }
        return $"{completionMarker} {_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}