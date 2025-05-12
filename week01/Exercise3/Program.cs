using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is your number? ");
        // string Console.ReadLine();
        // int number = int.Parse(Console.ReadLine());

         Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}