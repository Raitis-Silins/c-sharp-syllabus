using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main()
        {
            const int points = 10;
            var readText = File.ReadAllText(Path);
            var scores = readText.Split(' ');
            List<string> gradeList = new List<string>();

            string[] grade = {"00-09:","10-19:","20-29:","30-39:", "40-49:", "50-59:", "60-69:","70-79:","80-89:"
                ,"90-99:"," 100:"};
            gradeList.AddRange(grade);

            foreach (var value in scores)
            {
                var num = int.Parse(value) / points;
                grade[num] += "*";
            }

            for (int i = 0; i < gradeList.Count; i++)
            {
                string result = grade[i];
                Console.WriteLine(result);
            }
        }
    }
}