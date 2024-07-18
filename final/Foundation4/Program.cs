using System;

class Program
{
	static void Main(string[] args)
	{
		List<Activity> activities = new List<Activity>()
		{
			new Cycling(45,45),
			new Swimming(5,60,2),
			new Running(25,2)
		};
		foreach (Activity activity in activities)
		{
			Console.WriteLine(activity.GetSummary());
		}
	}
}