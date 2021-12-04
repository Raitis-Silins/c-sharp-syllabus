using System;

namespace Exercise7
{
    class Piglet
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Piglet!");
            Random random = new Random();

            var currentScore = 0;

            while (true)
            {
                var currentRoll = random.Next(1, 7);

                if (currentRoll == 1)
                {
                    currentScore = 0;
                    break;
                }

                currentScore += currentRoll;
                Console.WriteLine("You rolled {0}", currentRoll);
                Console.WriteLine("Roll again? y/n");

                var userInput = Console.ReadKey().KeyChar;

                if (userInput == 'y')
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }

            Console.WriteLine($"Your score was {currentScore} ");
        }
    }
}
