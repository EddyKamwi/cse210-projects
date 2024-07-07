using System.ComponentModel;

class BreathingActivity : Activity
{
    private const string _NAME = "Breathing Activity.";
    private const string _DESCRIPTION = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity(int duration=0, string name = _NAME, string description = _DESCRIPTION) : base(name, description, duration)
    {

    }
    public void Run()
    {
        Console.Clear();
        Console.Write("Get Ready ");

         base.ShowLoading(5);
        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime endCount = currentTime.AddSeconds(_duration);

        while (currentTime < endCount)
        {
            Console.Write("\n\nBreathe in ...");
            base.ShowCountDown(3);
            
            Console.Write("\nBreathe out ...");
            base.ShowCountDown(3);
            currentTime = DateTime.Now;
        }
        Console.WriteLine("\nWell done!!\n");
    }
}