using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            
            Console.WriteLine("Menu Options:  \n" +
                                "1. Start breathing activity  \n" +
                                "2. Start reflecting activity  \n" +
                                "3. Start listing activity  \n" +
                                "4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "1")
            {

            }
            else if (userAnswer == "2")
            {

            }
            else if (userAnswer == "3")
            {

            }
            else if (userAnswer == "4")
            {

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Select between 1 and 4");
                Thread.Sleep(4000);
                Console.Clear();
            }
        }
    }
}