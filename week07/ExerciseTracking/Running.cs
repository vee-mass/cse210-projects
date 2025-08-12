using System;

public class Running : Activity
{
    private double _runningDistance;

    public Running(DateTime date, double lengthMins, double runningDistance) : base(date, lengthMins)
    {
        _runningDistance = runningDistance;
    }

    public override double GetDistance()
    {
        return _runningDistance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMins) * 60;
    }

    public override double GetPace()
    {
        return LengthInMins / GetDistance();
    }
}
