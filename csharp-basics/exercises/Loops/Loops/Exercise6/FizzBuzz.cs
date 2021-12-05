using System;

namespace Exercise6
{
    class FizzBuzz
    {
        public static void Game()
        {
            Console.WriteLine("Enter an integer, that prints all of the numbers.");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
