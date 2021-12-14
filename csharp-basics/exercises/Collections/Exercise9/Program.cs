using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {

            var myText = new HashSet<string>();

            myText.Add("Flight");
            myText.Add("planner");
            myText.Add("was");
            myText.Add("really");
            myText.Add("hard");

            foreach (var text in myText)
            {
                Console.WriteLine(text);
            }

            myText.Clear();

            Console.WriteLine();

            myText.Add("Flight");
            myText.Add("Flight");

            foreach (var text in myText)
            {
                Console.WriteLine(text);
            }

        }
    }
}
