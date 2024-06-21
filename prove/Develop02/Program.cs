using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        Entry entry = new Entry();

        promptGenerator._prompts = [
            "Who was the most interesting person I interacted with today?\n> ",
            "What was the best part of my day?\n> ",
            "How did I see the hand of the Lord in my life today?\n> ",
            "What was the strongest emotion I felt today?\n> ",
            "If I had one thing I could do over today, what would it be?\n> ",
            "Did you minister to any one today? Who is in the most need to be ministered to?\n> ",
            "How often did I feel the Savior's love during the day?\n> ",
            "What was one thing I did to prepare myself to partake of the sacrament?\n> ",
            "Are you happy? Why?\n> "];
        //Display a welcome message
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            //diplays the prompt

            entry._promptText = "Please select one of the following choice: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do? ";
            entry.Display();

            if (entry._entryText == "1")
            {
                //write option
                entry._promptText = promptGenerator.GetRandomPrompt();
                entry.Display();

                string text = $"{entry._date}*{entry._promptText}*{entry._entryText}";
                journal.AddEntry(text);
                
            }

            else if (entry._entryText == "2")
            {
                journal.DisplayAll();
            }

            else if (entry._entryText == "3")
            {
                //Load option
                entry._promptText = "What is the filename?\n> ";
                entry.Display();
                journal.LoadFromFile(entry._entryText);
            }

            else if (entry._entryText == "4")
            {
                //save option
                entry._promptText = "What is the filename?\n> ";
                entry.Display();
                journal.SaveToFile(entry._entryText);
            }

            else if (entry._entryText == "5")
            {
                //quite option
                break;
            }


        }
    }
}