using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int user_num = int.Parse(Console.ReadLine());
        return user_num;
    }
    static int SquareNumber(int i)
    {
        return i * i;
    }
    static void DisplayResult(string user_name, int squareNumber)
    {
        Console.WriteLine($"{user_name}, the square of your number is {squareNumber}");
    }
}