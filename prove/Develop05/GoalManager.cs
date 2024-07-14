using System.Dynamic;

class GoalManager
{
    private int _score = 0;
    public void DisplayPoints()
    {
        string pointsMessage = $"You have {_score} points";
        Console.WriteLine(pointsMessage);
    }
    public Dictionary<string, string> _DicToSave = new Dictionary<string, string>();
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
        _DicToSave["Score"] = $"{this._score}";

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
        string score = _DicToSave["Score"];
        _score = int.Parse(score);
        _DicToSave.Remove("Score");

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

                //update record
                _DicToSave[_key] = $"{property[0]},{property[1]},{property[2]},{i},{property[4]},{property[5]},false";


                if (int.Parse(property[4]) == i)
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
                _DicToSave[_key] = $"{property[0]}, {property[1]}, {property[2]},false";
            }

        }
    }
    public void ListGoals()
    {
        int numbering = 1;
        foreach (var pair in _DicToSave)
        {

            string[] property = pair.Value.Split(",");
            //simple Goal
            if (property.Count() == 4)
            {
                string symbol = Mark(bool.Parse(property[property.Count() - 1]));
                print($"{numbering}. [{symbol}] {property[0]} ({property[1]})");
                numbering++;
            }
            //Eternal Goal
            else if (property.Count() == 3)
            {
                print($"{numbering}. [ ] {property[0]} ({property[1]})");
                numbering++;
            }
            //checklist Goal
            else if (property.Count() == 7)
            {
                string symbol = Mark(bool.Parse(property[property.Count() - 1]));
                print($"{numbering}. [{symbol}] {property[0]} ({property[1]}) ----currently completed: {property[3]}/{property[4]}");
                numbering++;
            }

        }
    }
    public string GetUserInfoToRecord()
    {
        string returnValue = ""; int numbering = 1;
        foreach (var pair in _DicToSave)
        {
            string[] property = pair.Value.Split(",");

            //show message if not complete


            if (pair.Key == "Eternal")
            {

                print($"{numbering}. {property[0].ToUpper()}");
                numbering++;
            }
            else if (pair.Key == "Checklist")
            {
                if (!bool.Parse(property[6]))
                {
                    print($"{numbering}. {property[0].ToUpper()}");
                    numbering++;
                }
            }
            else if (pair.Key == "Simple")
            {
                if (!bool.Parse(property[3]))
                {
                    print($"{numbering}. {property[0].ToUpper()}");
                    numbering++;
                }
            }

        }
        int ansInt = int.Parse(input("Which goal did you accomplish? "));
        int index = 1;
        foreach (var pair in _DicToSave)
        {
            string[] property = pair.Value.Split(",");

            if (index == ansInt)
            {
                returnValue = pair.Key;
            }
            index++;
        }

        return returnValue;
    }
    private string Mark(Boolean tf)
    {
        if (tf)
        {
            return "X";
        }
        else
        {
            return " ";
        }
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