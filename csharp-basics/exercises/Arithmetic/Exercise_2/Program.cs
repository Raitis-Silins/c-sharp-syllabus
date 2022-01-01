using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check if its odd or even");
            int numberEntered = int.Parse(Console.ReadLine());
            Console.WriteLine(new OddEven().CheckOddEven(numberEntered));
            Console.WriteLine("bye!");
        }
    }
}
