using System;

namespace Exercise4
{
    class Program
    {
        public static int IsHappyNumber(int num)
        {
            int counter = 0, sum = 0;
            while (num > 0)
            {
                counter = num % 10;
                sum = sum + (counter * counter);
                num = num / 10;
            }
            return sum;
        }

        public static void Main()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int result = num;
            while (result != 1 && result != 4)
            {
                result = IsHappyNumber(result);
            }

            if (result == 1)
            {
                Console.WriteLine(num + " is a happy number");
            }
            else if (result == 4)
            {
                Console.WriteLine(num + " is not a happy number");
            }
        }
    }
}