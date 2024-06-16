using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> user_list = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");

        int user_input_int = int.Parse(Console.ReadLine());
        int sum = 0;
        int largest_num = -1;
        int smallest_positive_num = 100;

        // adding elements to the user_list while the input is not equal to 0
        while (user_input_int != 0)
        {
            user_list.Add(user_input_int);
            Console.Write("Enter number: ");
            user_input_int = int.Parse(Console.ReadLine());
        }

        // finding the sum and the largest number of the numbers in the list
        foreach (int i in user_list)
        {

            sum += i;

            if (largest_num<i)
            {
                largest_num = i;
            }
            if(smallest_positive_num>i && i>0)
            {
                smallest_positive_num = i;
            }
        }
        // calculate the average by dividing the sum by number of elements in a list


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {user_list.Average()}");
        Console.WriteLine($"The largest number is: {largest_num}");
        Console.WriteLine($"The largest number is: {smallest_positive_num}");
    }
}