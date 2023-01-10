using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Principal Engineer";
        job1._company = "iOLAP";
        job1._startYear = "2022";
        job1._endYear = "current";

        Job job2 = new Job();
        job2._jobTitle = "Data Engineer";
        job2._company = "TripAdvisor";
        job2._startYear = "2020";
        job2._endYear = "2022";

        Resume cand1 = new Resume();
        cand1._name = "Juanito";

        cand1._jobs.Add(job1);
        cand1._jobs.Add(job2);

        cand1.Display();
    }
}