using System.IO;
using System.Collections.Generic;
public class Journal
{
    List<string> _entries = new List<string>();

    public void AddEntry(String newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (string _line in _entries)
        {
            
            Console.WriteLine($"Date {_line.Split("*")[0]} - Prompt: {_line.Split("*")[1]}\n{_line.Split("*")[2]}\n");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter _file = new StreamWriter($"../../../{file}"))
        {
            foreach (string item in _entries)
            {
                _file.WriteLine(item);
            }
        }
    }
    
    public void LoadFromFile(string file)
    {
        string[] _file = System.IO.File.ReadAllLines($"../../../{file}");
        foreach (string _entry in _file)
        {
            AddEntry(_entry);
        }
    }
}