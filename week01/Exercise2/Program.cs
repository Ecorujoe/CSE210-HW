using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade number: ");
        string valueFromUser = Console.ReadLine();

        int gradePercentage = int.Parse(valueFromUser);

        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }

        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePercentage > 70)
        {
            Console.WriteLine("Congratulations You have passed!");
        }

        else
        {
            Console.WriteLine("You failed. Hope you do better next session.");
        }
    }
}