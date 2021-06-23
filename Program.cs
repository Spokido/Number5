using System;

namespace NumberFiveConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number that is less than 5 :");

            string input = Console.ReadLine();

            double number;
            while (!double.TryParse(input, out number) || double.Parse(input) >= 5)
            {
                Console.WriteLine("Please enter a valid number less than 5:");
                input = Console.ReadLine();
            }

            Console.WriteLine($"The difference between {number} and 5 is :{5 - number}");

            Console.WriteLine();
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
  
        }
    }
}
