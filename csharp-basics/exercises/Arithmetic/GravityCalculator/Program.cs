
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var finalPosition = new Calculator().CalculateGravity(-9.81, 10.0, 0.0, 0.0);
            double fallingTime = 10.0;
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }

}

