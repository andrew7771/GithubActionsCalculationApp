using System;

namespace GithubActionsCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide two numbers as arguments.");
                return;
            }

            // Parse arguments
            if (int.TryParse(args[0], out int num1) && int.TryParse(args[1], out int num2))
            {
                int result = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is: {result}");
            }
            else
            {
                Console.WriteLine("Both arguments must be valid numbers.");
            }
        }
    }
}
