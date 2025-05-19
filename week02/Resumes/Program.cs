using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Microsoft";
        Job1._startYear = 2020;
        Job1._endYear = 2022;

        // Job1.Display();

        Job Job2 = new Job();
        Job2._jobTitle = "Sales Rep";
        Job2._company = "Samsung";
        Job2._startYear = 2022;
        Job2._endYear = 2024;

        // Job2.Display();

        Resume Resume1 = new Resume();

        Resume1._name = "TJ McCoy";

        Resume1._jobs.Add(Job1);
        Resume1._jobs.Add(Job2);

        Resume1.Display();
    }
}