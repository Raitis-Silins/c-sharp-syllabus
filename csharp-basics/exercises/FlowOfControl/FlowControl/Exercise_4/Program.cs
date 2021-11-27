using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDayInWord();
        }

        static void PrintDayInWord()
        {
            Console.WriteLine("Enter the number from 0-6 to get the day of the week");
            var userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }
        }
    }
}
