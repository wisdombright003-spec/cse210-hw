using System.Diagnostics;

public class Resume
{
    public string _givenName;
    public List<Job> _jobs = new List<Job>();  

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_givenName}");
        Console.WriteLine("Jobs");

        foreach (Job job in _jobs)
        {
            job.DisplayJoDetails();

        }
    }
}