using System.Runtime.CompilerServices;

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
        //store welcome message
        string msg = $"Welcome to the {_name}\n\n";

        //display welcome message in form of animation
        this.WordAnimation(msg);

        //store description
        msg = $"{_description}\n\n";

        //display description in form of animation
        this.WordAnimation(msg);
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
    public void ShowCountDown(int num)
    {
        for (int i = num; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(750);
            Console.Write("\b \b \b");
        }
    }
    private void WordAnimation(string sentence)
        {
            List<string> Msg = new List<string>();
            foreach (var word in sentence.Split(" "))
            {
                Msg.Add(word);
            }
            foreach (var item in Msg)
            {
                this.LetterAnimation(item);
                Thread.Sleep(100);
            }
        }
    private void LetterAnimation(string word)
        {
            List<char> Msg = new List<char>();
            foreach (var letter in word)
            {
                Msg.Add(letter);
            }
            foreach (var item in Msg)
            {
                Console.Write($"{item}");
                Thread.Sleep(100);
            }
            Console.Write(" ");
        }
}