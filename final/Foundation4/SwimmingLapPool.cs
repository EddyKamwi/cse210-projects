class Swimming : Activity
{
	private int _laps;


	public Swimming(int laps, double minutes) : base(minutes)
	{
		_laps = laps;
	}
	public override double GetPace()
	{
		double distance = this._laps * 50 / 1000;
		double pace = base._lengthInMinutes / distance;
		return pace;
	}
	public override double GetDistanceKm()
	{
		double distance = this._laps * 50 / 1000;
		return distance;
	}
	public override double GetSpeed()
	{
		double distance = this._laps * 50 / 1000;
		double speed = 60 * (distance / base._lengthInMinutes);
		return speed;
	}

}