using System;
using Microsoft.Win32.SafeHandles;

public abstract class Activity
{
    protected string _date;
    protected double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public virtual string GetSummary()
    {
        return $"{_date}({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
}