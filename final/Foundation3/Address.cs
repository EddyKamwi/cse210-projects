class Address
{
	private string _street;
	private string _city;
	private string _provinceState;
	private string _country;
	public Address(string street,string city,string provinceState,string country)
	{
		_street = street;
		_city = city;
		_provinceState = provinceState;
		_country = country;
	}
	public string GetAddressString()
	{
		return $"{this._street},\n{this._city}, {this._provinceState}\n{this._country}";
	}
}