using System;

partial class Program
{
    static void Main(string[] args)
    {
        JobTitle job1 = new JobTitle();
        job1._title = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        JobTitle job2 = new JobTitle();
        job2._title = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume.Name = "Lucas";
        resume.JobTitles.Add(job1);
        resume.JobTitles.Add(job2);

        resume.Display();

    }
}