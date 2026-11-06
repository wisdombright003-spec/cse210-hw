using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2022;
        job1._startYear = 2002;

        Job job2 = new Job();
        job2._jobTitle = "Audio Engineer";
        job2._company = "Apple";
        job2._endYear = 2026;
        job2._startYear = 2010;

        //job1.DisplayJoDetails();
        //job2.DisplayJoDetails();

        Resume myResume = new Resume();
        myResume._givenName = "Wisdom Sunday";

        //. Add the two jobs you created earlier, to the list of jobs in the resume object.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        

        // Verify that you can access and display the first job title using dot notation similar to myResume._jobs[0]._jobTitle .
        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.DisplayResume();
    
    }
}