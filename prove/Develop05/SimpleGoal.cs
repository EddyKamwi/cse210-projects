class SimpleGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public SimpleGoal(string name, string description, string points) : base(name, description, points) { }
    public override string GetStringRepresentation()
    {
        return"";
    }
}