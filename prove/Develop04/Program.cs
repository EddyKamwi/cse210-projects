using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.Clear();

            //display menu
            Console.WriteLine
            (
                "Menu Options:  \n" +
                "1. Start breathing activity  \n" +
                "2. Start reflecting activity  \n" +
                "3. Start listing activity  \n" +
                "4. Quit"
            );

            Console.Write("Select a choice from the menu: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "1")
            {
                //breathing activity     
                BreathingActivity breathingActivity = new BreathingActivity();

                //display welcome message
                Console.Clear();
                breathingActivity.DisplayStartingMessage();

                //take duration from user    
                Console.Write("How long in seconds, would you like for your session? ");
                breathingActivity.SetDuration(int.Parse(Console.ReadLine()));

                //run code
                breathingActivity.Run();

                //display ending message
                breathingActivity.DisplayEndingMessage();
                breathingActivity.ShowLoading(5);

            }
            else if (userAnswer == "2")
            {
                //reflecting activity
                ReflectingActivity reflectingActivity = new ReflectingActivity(int.Parse(userAnswer));
                //display welcome message
                Console.Clear();
                reflectingActivity.DisplayStartingMessage();

                //take duration from user    
                Console.Write("How long in seconds, would you like for your session ?");
                reflectingActivity.SetDuration(int.Parse(Console.ReadLine()));

                //run code
                reflectingActivity.Run();

                //display ending message
                reflectingActivity.DisplayEndingMessage();
                reflectingActivity.ShowLoading(5);


            }
            else if (userAnswer == "3")
            {
                //listing activity
                ListingActivity listingActivity = new ListingActivity(int.Parse(userAnswer));
                //display welcome message
                Console.Clear();
                listingActivity.DisplayStartingMessage();

                //take duration from user    
                Console.Write("How long in seconds, would you like for your session ?");
                listingActivity.SetDuration(int.Parse(Console.ReadLine()));

                //run code
                listingActivity.Run();

                //display ending message
                listingActivity.DisplayEndingMessage();
                listingActivity.ShowLoading(5);

            }
            else if (userAnswer == "4")
            {
                //quit
                break;
            }
            else
            {
                //out of range

                Console.Clear();
                Console.WriteLine("error!!! Select between 1 and 4");
                Thread.Sleep(4000);
                Console.Clear();
            }
        }
    }
}