class Lectures : Event
{
	private string _speaker;
	private int _capacity;
	public Lectures(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
	{
		_speaker = speaker;
		_capacity = capacity;
	}
	public override string FullDetails()
	{
		return $"Speaker: {this._speaker}.\nCapacity: {this._capacity}.\n{base.StandardDetails()}";
	}

}