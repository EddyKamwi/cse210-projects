class Address
{
	private string _street;
	private string _city;
	private string _stateOrProvice;
	private string _country;

	public Address(string street, string city, string state, string country)
	{
		_street = street;
		_city = city;
		_stateOrProvice = state;
		_country = country;
	}
	public bool IsUSA()
	{
		if (_country.ToLower() == "usa")

		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public string GetAddress()
	{
		return $"{this._street}, {this._city}\n" +
		$"{this._stateOrProvice},\n{this._country}.";
	}
}