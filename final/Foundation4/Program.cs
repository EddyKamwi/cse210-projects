using System;

class Program
{
	static void Main(string[] args)
	{
		List<Activity> activities = new List<Activity>()
		{
			new Cycling(35,20),
			new Swimming(20,10),
			new Running(25,2)
		};
		foreach (Activity activity in activities)
		{
			Console.WriteLine(activity.GetSummary());
		}
	}
}