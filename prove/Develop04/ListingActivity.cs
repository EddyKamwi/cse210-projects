public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private const string _NAME = "Listing Activity";
    private const string _DESCRIPTION = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public ListingActivity(int duration, string name = _NAME, string description = _DESCRIPTION) : base(name, description, duration)
    {

    }
    public void Run()
    {
        Console.Clear();
        Console.Write("Get Ready ");
        base.ShowLoading(5);

        //display question
        this.GetRandomPrompt();
        base.ShowCountDown(5);

        //get multiple user
        this.GetListFromUser();

        Console.WriteLine($"You listed {this._count} item(s)!");


        //good by message
        Console.WriteLine("\nWell done!!\n");
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();

        //add prompts to the list
        _prompts = new List<string>() { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
        int index = random.Next(_prompts.Count);

        //display the prompts
        Console.Write($"List as many responses as you can to the following prompt:\n" +
                        $" --- {_prompts[index]} --- \n" +
                        "You may begin in: \n");
    }
    private List<string> GetListFromUser()
    {
        //keep track of how may minutes
        List<string> userList = new List<string>();
        DateTime currentTime = DateTime.Now;
        DateTime endCount = currentTime.AddSeconds(_duration);

        while (currentTime < endCount)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        this._count = userList.Count;
        return userList;
    }
}