using System;
using System.Net.NetworkInformation;

public class Resume
{
    public string _name;


    //initializing my list to a new list before using it 

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");


        foreach (Job job in _jobs)
        {
            job.Display();
            
        }
    }
}