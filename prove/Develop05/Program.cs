using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();

        //loop main menu
        while (true)
        {
            //display points
            gm.DisplayPoints();
            //display menu
            gm.DisplayMainMenu();

            string ans = Console.ReadLine();
            //create goal
            if (int.Parse(ans) == 1)
            {
                gm.DisplayCreateGoalMenu();
                ans = Console.ReadLine();

                //create a simple goal
                if (int.Parse(ans) == 1)
                {

                    List<string> para = gm.CreateGoal();
                    Goal goal = new SimpleGoal(para[0], para[1], para[2]);
                    gm._DicToSave.Add("Simple", goal.GetDetailsString());
                }

                //create an Eternal goal
                else if (int.Parse(ans) == 2)
                {
                    List<string> para = gm.CreateGoal();
                    Goal goal = new EternalGoal(para[0], para[1], para[2]);
                    gm._DicToSave.Add("Eternal", goal.GetDetailsString());
                }

                //create a CheckList Goal
                else if (int.Parse(ans) == 3)
                {
                    List<string> para = gm.createListGoal();
                    Goal goal = new ChecklistGoal(para[0], para[1], para[2], int.Parse(para[3]), int.Parse(para[4]));
                    gm._DicToSave.Add("Checklist", goal.GetDetailsString());
                }
            }
            //list Goals
            else if (int.Parse(ans) == 2)
            {
                gm.print("The Goals are:");

                if (gm._DicToSave.Count != 0)
                {
                    gm.ListGoals();
                }

            }
            //save progress
            else if (int.Parse(ans) == 3)
            {
                //collect filename from user
                if (gm._DicToSave.Count != 0)
                {
                    string filename = gm.input("What is the filename of the Goal file?");
                    gm.SaveToFile(filename);

                }
                else
                { Console.Write("There are no goals to save!"); }
            }
            //load progress
            else if (int.Parse(ans) == 4)
            {
                string filename = gm.input("What is the filename of the Goal file?");
                gm.LoadFromFile(filename);
                ;
            }
            //record event
            else if (int.Parse(ans) == 5)
            {
                ans = gm.GetUserInfoToRecord();
                gm.RecordGoal(ans);
            }
            //quit or breake loop if user input quit
            else if (int.Parse(ans) == 6)
            {
                break;
            }
        }
    }
}