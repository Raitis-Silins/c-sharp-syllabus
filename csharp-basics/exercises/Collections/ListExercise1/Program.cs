using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Black");
            colors.Add("Blue");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
