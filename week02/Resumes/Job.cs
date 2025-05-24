public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _company;
    public string _jobTitle;

    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} , {_company} {_startYear} {_endYear}");
    }
}