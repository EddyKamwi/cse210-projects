using System;

class Program
{
    static void Main(string[] args)
    {

        DateTime startCount = DateTime.Now;
        Console.WriteLine(startCount);

        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(1500);
            }
            Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");
        }
    }
}