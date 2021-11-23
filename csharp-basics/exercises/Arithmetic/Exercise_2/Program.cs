using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check if its odd or even");
            int numberEntered = int.Parse(Console.ReadLine());
            CheckOddEven(numberEntered);
            Console.WriteLine("bye!");
        }
        static void CheckOddEven(int numberEntered)
        {
            if (numberEntered % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
