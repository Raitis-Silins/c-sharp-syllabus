using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            int x = -4 + userInput;
            var oneSide = (((userInput * 3) + x));

            Console.Write(new string('/', oneSide));
            Console.Write(new string('\\', oneSide));
            Console.WriteLine();

            for (int i = 1; i < userInput - 1; i++)
            {
                Console.Write(new string('/', oneSide - (i * 4)));
                Console.Write(new string('*', (4 * i) * 2));
                Console.Write(new string('\\', oneSide - (i * 4)));
                Console.WriteLine();
            }

            Console.Write(new string('*', (oneSide * 2)));

        }
    }
}
