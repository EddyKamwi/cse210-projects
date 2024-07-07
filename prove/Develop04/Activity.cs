public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine(
            $"Welcome to the {_name}\n\n"+
            $"{_description}\n\n"
        );
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n\nYou have completed another {_duration} seconds in the {_name}");
    }
    public void ShowLoading(int seconds)
    {
        DateTime startCount = DateTime.Now;
        DateTime endCount = startCount.AddSeconds(seconds);

        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(750);
            }
            Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");

            if (endCount <= DateTime.Now)
            {
                break;
            }
        }
    }
}