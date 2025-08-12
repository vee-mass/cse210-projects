using System;

public abstract class Activity
{
    protected DateTime _currentDate;
    protected double _lengthMins;

    public Activity()
    {
        _currentDate = DateTime.Today;
    }

    public Activity(DateTime date, double lengthMins)
    {
        _currentDate = date;
        _lengthMins = lengthMins;
    }

    public DateTime CurrentDate
    {
        get { return _currentDate; }
    }

    public double LengthInMins
    {
        get { return _lengthMins; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_currentDate: dd MMM yyyy} {this.GetType().Name} ({_lengthMins} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    } 

}