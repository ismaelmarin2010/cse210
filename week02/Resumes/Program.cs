using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("");


        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1999;
        job1._endYear = 2001;

        job1.Display();


        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Software Architect";
        job2._startYear = 2001;
        job2._endYear = 2003;

        job2.Display();


        Console.WriteLine("");
        Console.WriteLine("-----------------------");
        Console.WriteLine("");


        Resume ismaelJobs = new Resume();

        ismaelJobs._name = "Ismael Marin";
        ismaelJobs._jobs.Add(job1);
        ismaelJobs._jobs.Add(job2);

        ismaelJobs.Display();


        Console.WriteLine("");
        Console.WriteLine("");

    }
}