public class CheckListGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount;

    public CheckListGoal(string shortName, string description, int points, int targetCount, int bonusPoints)
        : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            MarkComplete();
            return GetPoints() + _bonusPoints;
        }
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()}) -- Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}|{GetShortName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}|{_targetCount}|{_bonusPoints}|{_currentCount}";
    }

    public void LoadExtraData(string[] parts)
    {
        _targetCount = int.Parse(parts[0]);
        _bonusPoints = int.Parse(parts[1]);
        _currentCount = int.Parse(parts[2]);
    }
}
