using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        // Console.Write("What is the magic number? ");
        // int magic_number = int.Parse(Console.ReadLine());
        string play = "Yes";

        while (play == "yes" || play == "Yes" || play == "YES")
        {
            Console.WriteLine("A magic number has been generated !!!");
            Console.Write("What is your guess? ");
            int user_guess = int.Parse(Console.ReadLine());
            int guess_count = 1;

            while (magic_number != user_guess)
            {
                if (user_guess > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

                Console.Write("What is your guess? ");
                user_guess = int.Parse(Console.ReadLine());
                guess_count++;
            }

            Console.WriteLine($"You guessed it with {guess_count} try(ies)!");
            Console.Write("Do you want to play again? yes or no : ");
            play = Console.ReadLine();
        }
    }
}