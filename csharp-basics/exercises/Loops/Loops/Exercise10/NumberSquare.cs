using System;

namespace Exercise10
{
    class NumberSquare
    {
        public static void Square()
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }
                for (int k = 0; k < i - min; k++)
                {
                    Console.Write(min + k);
                }
                Console.WriteLine();
            }
        }
    }
}
