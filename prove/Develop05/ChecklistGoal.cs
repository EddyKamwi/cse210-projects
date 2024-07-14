class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target = 0;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target && _target != 0)
        {
            return true;
        }
        else
        {
            return base.IsComplete();
        }
    }
    public override string GetStringRepresentation()
    {
        return $"[X] {_shortName} ({_description}) --currently completed: {this._amountCompleted}/{this._target}";
    }
    public override string GetDetailsString()
    {
        return $"{_shortName},{_description},{_points},{this._amountCompleted},{this._target},{this._bonus},{this.IsComplete()}";
    }
    public int UpdateAmountCompleted()
    {
        _amountCompleted += 1;
        return _amountCompleted;

    }
}