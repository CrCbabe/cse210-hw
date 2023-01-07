using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letterGrade = "";
        string message = "";

        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent >= 70)
        {
            letterGrade = "C";
        }
        else if (percent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (percent >= 70)
        {
            message = "Congratulations on passing this course!";
        }
        else
        {
            message = "Better luck next time!";
        }

        Console.WriteLine($"Your grade is: {letterGrade}. {message}");
    }
}