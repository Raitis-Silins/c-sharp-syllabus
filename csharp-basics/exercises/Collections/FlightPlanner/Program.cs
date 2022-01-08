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
        private static List<string> _read = File.ReadAllLines(Path).ToList();
        private static Dictionary<string, List<string>> _myDict = new Dictionary<string, List<string>>();

        private static void Main(string[] args)
        {
            FillDict();
            var flightAnalyst = new Planner(_myDict.ToDictionary(entry => entry.Key,
                entry => entry.Value));

            Console.WriteLine("To display list of the cities press 1 ");
            Console.WriteLine("To exit program press #");
            Console.Write("What would you like to do ");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine(flightAnalyst.PrintCity());
                Console.WriteLine("Select a start city");
                var startInput = Console.ReadLine();
                Console.WriteLine(flightAnalyst.StartingCity(startInput));
                Console.WriteLine("Choose the city: ");
                var nextDestination = Console.ReadLine();

                while (startInput != nextDestination)
                {
                    Console.WriteLine(flightAnalyst.StartingCity(nextDestination));
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
            foreach (var cities in _read)
            {
                string[] split = Regex.Split(cities, " -> ");

                if (_myDict.ContainsKey(split[0]))
                {
                    _myDict[split[0]].Add(split[1]);
                }
                else
                {
                    _myDict.Add($"{split[0]}", new List<string> { split[1] });
                }
            }
        }

    }
}
