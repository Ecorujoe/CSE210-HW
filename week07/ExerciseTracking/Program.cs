
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        var activities = new List<Activity>
        {
            new Running(new DateTime(2023, 08,06 ), 30, 2.0),
            new Cycling(new DateTime(2023, 09,03 ), 30, 15.0),
            new Swimming(new DateTime(2023, 10,08 ), 30, 20),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}
