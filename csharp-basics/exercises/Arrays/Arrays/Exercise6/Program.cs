using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            int[] arrayCopy = new int[array.Length];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(1, 101);
            }

            array.CopyTo(arrayCopy, 0);
            array[array.Length - 1] = -7;

            Console.WriteLine("Array 1: [{0}]", string.Join(" ", array));
            Console.WriteLine("Array 2: [{0}]", string.Join(" ", arrayCopy));
        }
    }
}
