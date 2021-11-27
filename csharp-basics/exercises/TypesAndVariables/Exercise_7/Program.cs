using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string and get the number of the uppercase letters in the string");
            string userInput = Console.ReadLine().ToString();

            var add = 0;
            foreach (var upperLetter in userInput)
            {
                if (char.IsUpper(upperLetter))
                {
                    add++;
                }
            }

            Console.WriteLine($"There are {add} uppercase letters");
        }
    }
}
