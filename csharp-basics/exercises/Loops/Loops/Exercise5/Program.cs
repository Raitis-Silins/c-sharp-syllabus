using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string secondWord = Console.ReadLine();

            var lengthBetween = 30 - firstWord.Length - secondWord.Length;

            Console.Write(firstWord);

            for (var i = 0; i < lengthBetween; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine(secondWord);
        }
    }
}
