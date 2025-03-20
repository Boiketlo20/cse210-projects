using System.Diagnostics.Contracts;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayList()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job jobs in _jobs)
        {
            jobs.DisplayJobDetails();
        }
    }
}