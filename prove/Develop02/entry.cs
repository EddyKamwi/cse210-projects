
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {

        Console.Write(_promptText);
        _entryText = Console.ReadLine();
        _date = DateTime.Now.ToShortDateString();
    }

}