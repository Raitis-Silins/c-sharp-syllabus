using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes to convert");
            int userInput = int.Parse(Console.ReadLine());

            var minutesInYear = 60 * 24 * 365;
            var years = (long)(userInput / minutesInYear);
            var days = (int)(userInput / 60 / 24) % 365;
            Console.WriteLine($"In {userInput} minutes are {years} years and {days} days");
        }
    }
}
