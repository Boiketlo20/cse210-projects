using System;
<<<<<<< HEAD
using Microsoft.VisualBasic;
=======
>>>>>>> c934f41ce3608ca76b6376432a905c5d626781eb

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Console.WriteLine("");

        Resume resumes = new Resume();
        resumes._name = "Yolanda Nzimande";
        resumes._jobs.Add(job1);
        resumes._jobs.Add(job2);
        // string myresume = resumes._jobs[0]._jobTitle;
        // Console.WriteLine(myresume);
        resumes.DisplayList();
=======
        Console.WriteLine("Hello World! This is the Resumes Project.");
>>>>>>> c934f41ce3608ca76b6376432a905c5d626781eb
    }
}