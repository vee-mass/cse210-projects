using System;

public class Swimming : Activity
{
    private int _numberOfLaps;
    private const double _metersPerLap = 50;

    public Swimming(DateTime date, double lengthMins, int numberOfLaps) : base(date, lengthMins)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * _metersPerLap / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthInMins * 60;
    }

    public override double GetPace()
    {
        return LengthInMins / GetDistance();
    }
}