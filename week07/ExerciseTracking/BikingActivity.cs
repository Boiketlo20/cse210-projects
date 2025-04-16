using System;

public class BikingActivity : Activity
{
    private double _speed;

    public BikingActivity(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * _minutes;
        return distance / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _minutes/GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Biking ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}