using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetShortName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;
    public bool IsComplete() => _isComplete;

    protected void MarkComplete()
    {
        _isComplete = true;
    }

    public abstract int RecordEvent(); // returns earned points

    public virtual string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public virtual void LoadFromString(string data)
    {
        string[] parts = data.Split('|');
        _shortName = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _isComplete = bool.Parse(parts[3]);
    }
}
