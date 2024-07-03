using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        MathAssignment assignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}