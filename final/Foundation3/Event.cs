class Event
{
	private string _title;
	private string _description;
	private string _date;
	private string _time;
	private string _address;
	public Event(string title, string description, string date, string time, string address)
	{
		_title = title;
		_description = description;
		_date = date;
		_time = time;
		_address = address;
	}
	public string StandardDetails()
	{
		return $"Title: {this._title}. \nDescription: {this._description}. \nDate: {this._date}. \nTime: {this._time}. \nAddress: {this._address}.";
	}
	public virtual string FullDetails()
	{
		return this.StandardDetails();
	}
	public string ShortDescription()
	{
		return $"Type: {this}. \nTitle: {this._title}. \nDate: {this._date}";
	}
}