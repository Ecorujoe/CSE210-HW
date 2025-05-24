using System;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Welcome to the program!");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Please enter  your favourite number: ");
            int favouriteNumber = int.Parse(Console.ReadLine());
            int squareNumber = favouriteNumber * favouriteNumber;
            Console.WriteLine($"{userName}, the squrare of your favourite number is {squareNumber} ");
    }
}