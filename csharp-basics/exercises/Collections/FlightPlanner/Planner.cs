using System;
using System.Collections.Generic;

namespace FlightPlanner
{
    public class Planner
    {
        private Dictionary<string, List<string>> _myDict;

        public Planner(Dictionary<string, List<string>> myDict)
        {
            _myDict = myDict;
        }

        public string PrintCity()
        {
            var fill = "";
            foreach (var cities in _myDict)
            {
                fill += cities.Key + "\n";
            }

            return fill;
        }

        public string StartingCity(string userInput)
        {
            var fill = "";
            if (_myDict.ContainsKey(userInput))
            {
                var Value = _myDict[userInput];
                foreach (var city in Value)
                {
                    fill += $"You're destinations: {city}" + "\n";
                }
            }

            return fill;
        }
    }
}