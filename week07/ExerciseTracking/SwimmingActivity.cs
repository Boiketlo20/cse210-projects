using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double lap = _laps * 50;
        return lap / 1000;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance()/_minutes;
        return speed * 60;
    }

    public override double GetPace()
    {
        return _minutes/GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}