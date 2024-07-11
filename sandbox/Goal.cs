public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public bool IsComplete()
    { return false; }
    private string GetDetailsString()
    {
        return "";
    }
    private string GetStringRepresentation()
    {
        return "";
    }
}