using System;

class Program
{
    static void Main(string[] args)
    {
        // define the variables to be used
        string plus = "+";
        string minus = "-";
        string grade_letter = "Grade";
        string grade_percent_string;
        int grade_percent_int;

        Console.Write("Enter your grade percentage ");
        grade_percent_string = Console.ReadLine();
        // convert the input so as to use it in the comparisons bellow

        grade_percent_int = int.Parse(grade_percent_string);

        if (grade_percent_int >= 90)
        {
            grade_letter = "A";
        }
        else if (grade_percent_int >= 80)
        {
            grade_letter = "B";
        }
        else if (grade_percent_int >= 70)
        {
            grade_letter = "C";
        }
        else if (grade_percent_int >= 60)
        {
            grade_letter = "D";
        }
        else if (grade_percent_int < 60)
        {
            grade_letter = "F";
        }

        if (grade_percent_int % 10 >= 7 && 80 > grade_percent_int && grade_percent_int >= 60)
        {
            grade_letter = grade_letter + plus;
        }
        else if (grade_percent_int % 10 < 3 && grade_percent_int >= 60)
        {
            grade_letter = grade_letter + minus;
        }

        Console.WriteLine($"Your grade letter is : {grade_letter}");

        if (grade_percent_int > 70)
        {
            Console.WriteLine("Congratulation for scoring a high grade!");
        }
        else
        {
            Console.WriteLine("You failed to proceed to the next round, but do not worry you are one try away from passing.");
        }
    }
}