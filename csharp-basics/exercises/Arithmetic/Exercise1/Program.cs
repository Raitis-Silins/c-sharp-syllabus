using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            int firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            int secondInput = int.Parse(Console.ReadLine());
            Console.WriteLine(new Check15().CheckIntegers(firstInput,secondInput));
        }
    }
}
