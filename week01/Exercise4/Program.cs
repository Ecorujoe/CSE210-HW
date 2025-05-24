using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        List<int> numbers = new List<int>();

       
        //assusiming the first number is the max
        do
        {


            Console.Write("Enter a list of numbers, type 0 when finished. ");
            userInput = int.Parse(Console.ReadLine());
            
             if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        } while (userInput != 0);

        // Ensure the list is not empty
        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];  // Start with the first number

            foreach (int number in numbers)
            {
                sum += number;

                if (number > max)
                {
                    max = number;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Maximum number: {max}");

            // Find the smallest positive number manually

            int smallestPositive = int.MaxValue;
            bool foundPositive = false;

            foreach (int number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                    foundPositive = true;
                }

            }
            numbers.Sort();
        } 
    }
}