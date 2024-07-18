class Running : Activity
{
	private double _distance;

	public Running(double minutes, double distanceInKm) : base(minutes)
	{
		_distance = distanceInKm;
	}
	public override double GetPace()
	{
		double pace = base._lengthInMinutes/_distance;
		return pace;
	}
	public override double GetSpeed()
	{
		double speed =  60 * (_distance/base._lengthInMinutes);
		return speed;
	}
	public override double GetDistanceKm()
	{
		return _distance;
	}

}