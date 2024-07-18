using System;
using System.Xml.Linq;

class Program
{
	static void Main(string[] args)
	{
		Customer american = new Customer("Kane", new Address("Straight Path", "Some City", "Los Angels", "USA"));
		Customer indian = new Customer("Abram", new Address("12 Sam Street", "Lost City", "Tokyo", "Virtual India"));

		List<Product> groceries = new List<Product>()
		{
			new Product("Egg",123,0.25,30),
			new Product ("Bread Flour",124,10,1),
			new Product("Potatoe",125,6.1,1)
		};

		List<Product> fruits = new List<Product>()
		{
			new Product("Orange",126,0.5,10),
			new Product ("Banana",127,0.4,30),
			new Product ("Apple",128,0.5,12)
		};
		List<Order> orders = new List<Order>()
		{
			new Order(american,groceries),
			new Order(indian,fruits)
		};
		
		foreach (Order order in orders)
		{
			Console.WriteLine($"\n\nYour Packing Label: ");order.PackingLabel();
			Console.WriteLine($"\nYour Shipping Label: ");order.ShippingLabel();
			Console.WriteLine($"\nTotal Price: ${order.CalculateTotalPrice()}");
		}
	}
}