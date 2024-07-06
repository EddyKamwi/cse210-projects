using System.Configuration.Assemblies;

class ReflectingActivity:Activity
{
    private List<string> _propmts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration): base(name,description,duration)
    {
    }
    public void Run()
    {

    }
    private string GetRandomPrompt()
    {
        return "";
    }
    private string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}