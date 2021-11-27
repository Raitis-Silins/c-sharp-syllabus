using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }

        static void Second()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            double d = 4.2;
            double e = 5.3;

            double sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}