class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }
    public override string GetStringRepresentation()
    {
        return $"[X] {_shortName} ({_description})";
    }
    public override string GetDetailsString()
    {
        return $"{_shortName},{_description},{_points},{this.IsComplete}";
    }
}