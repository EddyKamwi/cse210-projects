public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {

    }
    public void DisplayEndingMessage()
    {

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
                Thread.Sleep(1500);
            }
            Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");

            if (endCount <= DateTime.Now)
            {
                break;
            }
        }
    }
}