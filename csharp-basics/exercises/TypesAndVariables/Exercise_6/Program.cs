using System;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SumNumbers();
        }

        static void SumNumbers()
        {
            Console.WriteLine("Enter number you want to get sum of");
            long userInput = long.Parse(Console.ReadLine());

            long result = userInput.ToString().Sum(x => x - '0');
            Console.WriteLine("Sum of {0} is {1}", userInput, result);
        }
    }
}
