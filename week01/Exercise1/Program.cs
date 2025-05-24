using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is Your First Name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is Your last Name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}