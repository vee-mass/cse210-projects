public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            MarkComplete();
            return GetPoints();
        }
        return 0;
    }
}
