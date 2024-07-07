using System.Configuration.Assemblies;

class ReflectingActivity : Activity
{
    private List<string> _propmts;
    private List<string> _questions;
    private const string _NAME = "Reflecting Activity";
    private const string _DESCRIPTION = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    Random random = new Random();
    public ReflectingActivity(int duration, string name = _NAME, string description = _DESCRIPTION) : base(name, description, duration)
    {

    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready");
        base.ShowLoading(5);

        Console.WriteLine(
            "Consider the following prompt:\n" +
            $" --- {this.GetRandomPrompt()} --- \n" +
            "When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience.\n" +
                        "You may begin in: ");
        base.ShowCountDown(8);
        Console.Clear();


        DateTime currentTime = DateTime.Now;
        DateTime endCount = currentTime.AddSeconds(_duration);

        while (currentTime<endCount)
        {
            this.DisplayQuestion();
            base.ShowLoading(8);
            Console.WriteLine();
            
            //check current time
            currentTime = DateTime.Now;
        }
        Console.WriteLine("\nWell done!!\n");
    }
    private string GetRandomPrompt()
    {
        _propmts = new List<string>() { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };

        return _propmts[random.Next(_propmts.Count)];
    }
    private string GetRandomQuestion()
    {
        _questions = new List<string>() { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
        return _questions[random.Next(_questions.Count)];
    }
    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }
}