abstract class Activity
{
	protected string _date = DateTime.Now.ToShortDateString();
	protected double _lengthInMinutes;
	protected double _distance;
	public Activity(double minutes, double distanceInKm)
	{
		_lengthInMinutes = minutes;
		_distance = distanceInKm;
	}
	public abstract double GetDistanceKm();
	
	public abstract double GetSpeed();
	
	public abstract double GetPace();

	public string GetSummary()
	{
		return $"{this._date} {this}({this._lengthInMinutes}min): Distance {this._distance}Km, Speed {this.GetSpeed()}kph, Pace: {this.GetPace()} min per km";
	}
}