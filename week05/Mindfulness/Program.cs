
// updated line 7 under Mindfullness Activity for _underscoreCamelCase
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity: ");
            
            string choice = Console.ReadLine();

            MindfulnessActivity activity = null;
            
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            // Start the selected activity
            activity.Start();
        }
    }
}