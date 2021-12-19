using System;

namespace Exercise4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number");
            var num = int.Parse(Console.ReadLine());
            var result = num;

            while (result != 1 && result != 4)
            {
                result = IsHappyNumber(result);
            }

            if (result == 1)
            {
                Console.WriteLine(num + " is a happy number");
            }
            else
            {
                Console.WriteLine(num + " is not a happy number");
            }
        }

        public static int IsHappyNumber(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                var counter = num % 10;
                sum = sum + (counter * counter);
                num = num / 10;
            }

            return sum;
        }
    }
}