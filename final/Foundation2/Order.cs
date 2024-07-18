class Order
{
	private List<Product> _products = new List<Product>();
	private Customer _customer;
	private double _totalCost;
	public Order(Customer customer,List<Product> products)
	{
		_products = products;
		_customer = customer;
	}
	public void PackingLabel()
	{
		foreach (Product product in _products)
		{
			Console.WriteLine($"{product.GetProductNameId()}");
		}
		Console.WriteLine($"Shipping Cost: ${this.CalculateShippingCost()}");
	}
	public void ShippingLabel()
	{
	Console.WriteLine(_customer.GetCustomerNameAddress());
	}
	public double CalculateShippingCost()
	{
		if (_customer.LivesInUSA())

		{
			return 5.0;
		}
		return 35.0;
	}
	public double CalculateTotalPrice()
	{
		foreach (Product product in _products)
		{
			_totalCost += product.TotalCost();
		}

		return _totalCost + this.CalculateShippingCost();
	}


}