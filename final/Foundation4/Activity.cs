abstract class Activity
{
	protected string _date = DateTime.Now.ToShortDateString();
	protected double _lengthInMinutes;
	
	public Activity(double minutes)
	{
		_lengthInMinutes = minutes;
	}
	public abstract double GetDistanceKm();
	
	public abstract double GetSpeed();
	
	public abstract double GetPace();

	public string GetSummary()
	{
		return $"{this._date} {this}({this._lengthInMinutes}min): Distance {this.GetDistanceKm()}Km, Speed {this.GetSpeed()}kph, Pace: {this.GetPace()} min per km";
	}
}