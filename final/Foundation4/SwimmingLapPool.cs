class Swimming : Activity
{
	private int _numberOfLaps;


	public Swimming(int laps, double minutes, double distanceInKm) : base(minutes, distanceInKm)
	{
		_numberOfLaps = laps;
	}
	public override double GetPace()
	{
		double pace = base._lengthInMinutes/base._distance;
		return pace;
	}
	public override double GetDistanceKm()
	{
		return (this._numberOfLaps * 50) / 1000;
	}
	public override double GetSpeed()
	{
		double speed =  60 * (base._distance/base._lengthInMinutes);
		return speed;
	}

}