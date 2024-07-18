class Cycling : Activity
{
	private double _speed;
	public Cycling(double minutes, double speed) : base(minutes)
	{
		_speed = speed;
	}
	public override double GetPace()
	{
		double pace = 60/this._speed;
		return pace;
	}
	public override double GetDistanceKm()
	{
		return this._speed/base._lengthInMinutes;
	}
	public override double GetSpeed()
	{
		return _speed;
	}
}