class Running : Activity
{

	public Running(double minutes, double distanceInKm) : base(minutes, distanceInKm)
	{
	}
	public override double GetPace()
	{
		double pace = base._lengthInMinutes/base._distance;
		return pace;
	}
	public override double GetSpeed()
	{
		double speed =  60 * (base._distance/base._lengthInMinutes);
		return speed;
	}
	public override double GetDistanceKm()
	{
		return base._distance;
	}

}