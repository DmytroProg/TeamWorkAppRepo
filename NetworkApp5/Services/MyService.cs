using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkApp5.Services
{
    public static class MyService
    {
        public static void DoWork()
        {
            Random rand = new Random();

            Console.WriteLine("Game: Guess num (1–20)");
            Console.WriteLine();

            int secret = rand.Next(1, 21);
            int attempts = 0;
            bool guessed = false;

            while (!guessed)
            {
                Console.Write("Enter num: = ");
                string? input = Console.ReadLine();
                attempts++;

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Value error");
                    continue;
                }

                if (guess < 1 || guess > 20)
                {
                    Console.WriteLine("Enter num from 1 to 20.");
                    continue;
                }

                if (guess == secret)
                {
                    Console.WriteLine($"Correct.");
                    guessed = true;
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Small!");
                }
                else
                {
                    Console.WriteLine("Big!");
                }
            }
        }
    }
}