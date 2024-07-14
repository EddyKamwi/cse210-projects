using System.Dynamic;

class GoalManager
{
    private int _score = 0;
    public Dictionary<string, string> _DicToSave = new Dictionary<string, string>();
    public GoalManager() { }
    public void DisplayPoints()
    {
        string pointsMessage = $"You have {_score} points";
        Console.WriteLine(pointsMessage);
    }
    public void DisplayMainMenu()
    {
        string menu = "Menu Options:\n" +
                        "  1. Create New Goal\n" +
                        "  2. List Goals\n" +
                        "  3. Save Goals\n" +
                        "  4. Load Goals\n" +
                        "  5. Record Event\n" +
                        "  6. Quit\n" +
                        "Select a choice from the menu: ";

        Console.Write(menu);
    }
    public void UpdateScore(int score)
    {
        _score += score;
    }
    public void DisplayCreateGoalMenu()
    {
        string menu = "  1. Simple Goal\n" +
                        "  2. Eternal Goal\n" +
                        "  3. Checklist Goal\n" +
                        "Which type of goal would you like to create? ";

        Console.Write(menu);
    }
    public List<string> CreateGoal()
    {
        string name; string descrip; string points;
        name = input("what is the name of your goal?");
        descrip = input("What is a short description of it?");
        points = input("What is the amount of points associated with this goal?");
        return [name, descrip, points];
    }
    public List<string> createListGoal()
    {
        List<string> strings = new List<string>();
        strings = CreateGoal();
        string bonus; string count;
        count = input("How many times does this goal need to be accoplished for a bonus?");
        strings.Add(count);
        bonus = input("What is the bonus for accomplishing it that many times?");
        strings.Add(bonus);

        return strings;
    }
    public int ReadLineInt(string str)
    {
        Console.Write(str);
        return int.Parse(Console.ReadLine());
    }
    public string input(string str)
    {
        Console.Write(str);
        return Console.ReadLine();
    }
    public void SaveToFile(string filename)
    {

        using (StreamWriter _file = new StreamWriter($"../../../{filename}"))
        {
            foreach (var pair in _DicToSave)
            {
                _file.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        //empty the dictionary
        _DicToSave = new Dictionary<string, string>() { };

        //add items to the dictionary _virtualFile
        string[] _file = System.IO.File.ReadAllLines($"C:\\Users\\Code\\Documents\\GitHub\\cse210-projects\\prove\\Develop05\\{filename}");

        foreach (string line in _file)
        {
            string[] pair = line.Split(":");
            _DicToSave.Add(pair[0], pair[1]);
        }

    }
    public void RecordGoal(string _key)
    {
        foreach (var pair in _DicToSave)
        {
            if (pair.Key == _key && _key == "Checklist")
            {
                string[] property = pair.Value.Split(",");
                UpdateScore(int.Parse(property[2]));

                int i = int.Parse(property[3]) + 1;

                property[3] = i.ToString();
                //update record
                _DicToSave[_key] = $"{property[0]},{property[1]},{property[2]},{property[3]},{property[4]},{property[5]}";


                if (int.Parse(property[4]) == int.Parse(property[3]))
                {
                    UpdateScore(int.Parse(property[5]));
                    _DicToSave[_key] = $"{property[0]},{property[1]},{property[2]},{property[3]},{property[4]},{property[5]},true";
                }
            }
            else if (pair.Key == _key && _key == "Simple")
            {
                string[] property = pair.Value.Split(",");
                UpdateScore(int.Parse(property[2]));
                _DicToSave[_key] = $"{property[0]},{property[1]},{property[2]},true";
            }
            else if (pair.Key == _key && _key == "Eternal")
            {
                string[] property = pair.Value.Split(",");
                UpdateScore(int.Parse(property[2]));
                _DicToSave[_key] = $"{property[0]}, {property[1]}, {property[2]}";
            }

        }
    }
    public string GetUserInfoToRecord()
    {
        string ans = ""; int numbering = 1;
        foreach (var pair in _DicToSave)
        {
            string[] property = pair.Value.Split(",");

            print($"{numbering}. {property[0].ToUpper()}");

            numbering++;
        }
        int ansInt = int.Parse(input("Which goal did you accomplish? "));
        int index = 1;
        foreach (var pair in _DicToSave)
        {
            string[] property = pair.Value.Split(",");

            if (index == ansInt)
            {
                ans = pair.Key;
            }
            index++;
        }

        return ans;
    }
    public void print(string str)
    {
        Console.WriteLine(str);
    }
    public void print(int str)
    {
        Console.WriteLine(str);
    }
}