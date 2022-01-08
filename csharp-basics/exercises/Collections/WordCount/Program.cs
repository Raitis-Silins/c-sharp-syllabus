using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "../../lear.txt";
            var text = new Calculate(File.ReadAllText(path));

            Console.WriteLine("Lines: " + text.LinesInText());
            Console.WriteLine("Words: " + text.WordsInText());
            Console.WriteLine("Chars: " + text.CharsInText());
        }
    }
}
