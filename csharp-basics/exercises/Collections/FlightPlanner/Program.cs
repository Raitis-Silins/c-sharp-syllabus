using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        private static List<string> read = File.ReadAllLines(Path).ToList();
        private static Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();

        private static void Main(string[] args)
        {
            Console.WriteLine("To display list of the cities press 1 ");
            Console.WriteLine("To exit program press #");
            Console.Write("What would you like to do ");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                FillDict();
                PrintCity();
                Console.WriteLine("Select a start city");
                var startInput = Console.ReadLine();
                StartingCity(startInput);

                Console.WriteLine("Choose the city: ");
                var nextDestination = Console.ReadLine();

                while (startInput != nextDestination)
                {
                    StartingCity(nextDestination);
                    Console.WriteLine("Choose the city: ");
                    nextDestination = Console.ReadLine();
                }

                Console.WriteLine("Welcome home");
            }

            if (userInput == "#")
            {
                Console.Clear();
                Console.WriteLine("You did nothing, good day Sir!");

            }

        }

        private static void FillDict()
        {
            foreach (var cities in read)
            {
                string[] split = Regex.Split(cities, " -> ");

                if (myDict.ContainsKey(split[0]))
                {
                    myDict[split[0]].Add(split[1]);
                }
                else
                {
                    myDict.Add($"{split[0]}", new List<string> { split[1] });
                }
            }
        }

        static void PrintCity()
        {
            foreach (var cities in myDict)
            {
                Console.WriteLine(cities.Key);
            }
        }

        static void StartingCity(string userInput)
        {
            if (myDict.ContainsKey(userInput))
            {
                var Value = myDict[userInput];
                foreach (var city in Value)
                {
                    Console.WriteLine($"You'r destinations: {city}");
                }
            }

            Console.WriteLine();
        }
    }
}
