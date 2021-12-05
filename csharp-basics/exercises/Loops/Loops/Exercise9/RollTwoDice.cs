using System;

namespace Exercise9
{
    class RollTwoDice
    {
       public static void Dice()
        {
            var userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Desired sum: {userInput}");

            Random random = new Random();

            var dice1 = random.Next(1, 7);
            var dice2 = random.Next(1, 7);
            var diceSum = dice1 + dice2;

            while (diceSum != userInput)
            {
                dice1 = random.Next(1, 7);
                dice2 = random.Next(1, 7);
                diceSum = dice1 + dice2;
                Console.WriteLine($"{dice1} and {dice2} = {diceSum}");
            }
        }
    }
}
