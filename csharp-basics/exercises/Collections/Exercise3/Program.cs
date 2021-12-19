using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();

            Console.WriteLine("Enter names");

            while (!namesList.Contains(""))
            {
                namesList.Add(Console.ReadLine());
            }

            var unique = new HashSet<string>(namesList);
            Console.Write($"Unique name list contains: ");

            foreach (var name in unique)
            {
                Console.WriteLine(name);
            }
        }
    }
}
