using System;

public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, double lengthMins, double speedMph) : base(date, lengthMins)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance()
    {
        return _speedMph * (LengthInMins / 60.0);
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetPace()
    {
        return 60.0 / _speedMph;
    }
}
