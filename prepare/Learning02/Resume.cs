using System;

class Resume
{

    public string _name = string.Empty;
    public List<Job> _jobs = new List<Job>();
    public Resume()
    {

    }

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