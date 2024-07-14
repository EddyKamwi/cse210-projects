abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public void RecordEvent(Goal goal)
    {
        Console.WriteLine($"{GetDetailsString()}, {goal.IsComplete()}");
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public abstract string GetDetailsString();
    public int GetPoints()
    {
        return int.Parse(_points);
    }

    public abstract string GetStringRepresentation();
}