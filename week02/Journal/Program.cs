using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Please select one of the following choices (1-5): ");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");

        string selection = Console.ReadLine();

        if (selection == "1")
        {
            journal.Write();
        }
        else if (selection == "2")
        {
            journal.Display();
        }
        else if (selection == "3")
        {
            journal.Save();
        }
        else if (selection == "4")
        {
            journal.Load();
        }
        else
        {
            Console.WriteLine("Thank you. Goodbye.");
        }

    }
}