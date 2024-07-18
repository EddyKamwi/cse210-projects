class Cycling : Activity
{
	public Cycling(double minutes,double distanceInKm) : base(minutes,distanceInKm)
	{
		
	}
	public override double GetPace()
	{
		double pace = base._lengthInMinutes/base._distance;
		return pace;
	}
	public override double GetDistanceKm()
	{
		return _distance;
	}
	public override double GetSpeed()
	{
		double speed =  60 * (base._distance/base._lengthInMinutes);
		return speed;
	}
}