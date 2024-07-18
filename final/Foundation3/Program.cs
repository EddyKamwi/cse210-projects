using System;

class Program
{
	static void Main(string[] args)
	{
		List<Event> events = new List<Event>()
		{
			//first parameter
			new Lectures
			(
				"Inheritance",
				"Learn how Mr Newton has used Inheritance to create proffessional programs",
				DateTime.Now.ToShortDateString(),
				DateTime.Now.ToShortTimeString(),
				new Address("1234 st Avenue","Y City","AB State", "Black Foot").GetAddressString(),
				"Sir Newton",
				50
			),
			
			//second parameter
			new OutdoorGathering
			(
				"Birthday Party",
				"Wright is celebrating his 35th birthday with his friends and family",
				DateTime.Now.ToShortDateString(),
				DateTime.Now.ToShortTimeString(),
				new Address("123 rd Avenue","W City","AD State","New York").GetAddressString(),
				"Sunny"
			),
			
			//third parameter
			new Receptions
			(
				"Weeding",
				"Mr and Mrs Long to be are getting married",
				DateTime.Now.ToShortDateString(),
				DateTime.Now.ToShortTimeString(),
				new Address("123 nd Avenue","X City","C Province","South Africa").GetAddressString(),
				"josephlong@gmail.com"
			)
		};
		//loop through the events
		foreach (Event @event in events)
		{
			Console.WriteLine($"Short Description: \n{@event.ShortDescription()}\n");
			Console.WriteLine($"Standard Details: \n{@event.StandardDetails()}\n");
			Console.WriteLine($"Full Details: {@event.FullDetails()}\n");
		}

	}
}