using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "../../lear.txt";

            string content = File.ReadAllText(path, Encoding.UTF8);

            var lines = File.ReadAllLines(path).ToList();
            var words = Regex.Matches(content, @"[A-Za-z]+").Count;
            var chars = File.ReadAllLines(path).Sum(s => s.Length);

            Console.WriteLine($"Lines {lines.Count}");
            Console.WriteLine($"Words {words}");
            Console.WriteLine($"Chars {chars}");
        }
    }
}
