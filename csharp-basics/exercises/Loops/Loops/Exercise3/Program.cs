using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 20);
            }

            Console.WriteLine("Which number position out of 20 random numbers you want to know");
            var userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Your number is {0}", array[userInput]);
        }
    }
}
