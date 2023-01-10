using System;

public class Job
{

    public string _company = string.Empty;
    public string _jobTitle = string.Empty;
    public string _startYear = string.Empty;
    public string _endYear = string.Empty;

    public Job()
    {

    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}