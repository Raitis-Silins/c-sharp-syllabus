using System;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string class1 = "English III";
            string class2 = "Precalculus";
            string class3 = "Music Theory";
            string class4 = "Biotechnology";
            string class5 = "Principles of Technology I";
            string class6 = "Latin II";
            string class7 = "AP US History";
            string class8 = "Polish cosmic science";

            string teacher1 = "Ms. Lapan";
            string teacher2 = "Mrs. Gideon";
            string teacher3 = "Mr. Davis";
            string teacher4 = "Ms. Palmer";
            string teacher5 = "Ms. Garcia";
            string teacher6 = "Mrs. Barnett";
            string teacher7 = "Ms. Johannessen";
            string teacher8 = "Mr. Jakub";

            Console.WriteLine("+"+String.Concat(Enumerable.Repeat("-", 49))+"+");
            Console.WriteLine($"| 1 | {class1,26} | { teacher1,15}|");
            Console.WriteLine($"| 2 | {class2,26} | { teacher2,15}|");
            Console.WriteLine($"| 3 | {class3,26} | { teacher3,15}|");
            Console.WriteLine($"| 4 | {class4,26} | { teacher4,15}|");
            Console.WriteLine($"| 5 | {class5,26} | { teacher5,15}|");
            Console.WriteLine($"| 6 | {class6,26} | { teacher6,15}|");
            Console.WriteLine($"| 7 | {class7,26} | { teacher7,15}|");
            Console.WriteLine($"| 8 | {class8,26} | { teacher8,15}|");
            Console.WriteLine("+" + String.Concat(Enumerable.Repeat("-", 49)) + "+");
        }
    }
}
