using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input > 0)
        {
            Console.WriteLine($"\nMultiplication table for {input}:");
            for (int i = 1; i <= 10; i++)
            {
                int result = input * i;
                Console.WriteLine($"{input} × {i} = {result}");
            }
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }

        Console.WriteLine("\nPress any key for exit...");
        Console.ReadKey();
    }
}
