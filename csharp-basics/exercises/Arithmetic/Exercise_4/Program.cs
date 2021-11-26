using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1ToN();
        }

        static void Product1ToN()
        {
            int factorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
