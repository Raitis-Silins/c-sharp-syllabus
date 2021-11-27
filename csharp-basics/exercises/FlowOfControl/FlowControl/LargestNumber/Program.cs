using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = int.Parse(Console.ReadLine());

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine($"Number {input1} is the largest");
            }
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine($"Number {input2} is the largest");
            }
            else if (input3 > input1 && input3 > input2)
            {
                Console.WriteLine($"Number {input3} is the largest");
            }
        }
    }
}
