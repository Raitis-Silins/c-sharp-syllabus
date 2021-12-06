using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            var result = 0;
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
           
            for (i = 0; i <= n; i++)
            {
                result = i * n;
            }

            Console.WriteLine(result);
        }
    }
}
