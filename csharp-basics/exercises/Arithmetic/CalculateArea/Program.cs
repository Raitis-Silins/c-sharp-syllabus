using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
        }

        public static int GetMenu()
        {
            
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.Write("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey().KeyChar.ToString();
            int userChoice = int.Parse(keyboard);

            if (userChoice == 1)
            {
                CalculateCircleArea();
            } 
            else if (userChoice == 2)
            {
                CalculateRectangleArea();
            } 
            else if (userChoice == 3)
            {
                CalculateTriangleArea();
            } 
            else if (userChoice == 4)
            {
                Console.WriteLine("\nQuit");
            }
            else
            {
                Console.WriteLine("\nWrong input");
            }
            
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("\nWhat is the circle's radius? ");
            decimal radius = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nThe circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("\nEnter length? ");
            decimal length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter width? ");
            decimal width = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nThe rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("\nEnter length of the triangle's base? ");
            decimal ground = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter triangle's height? ");
            decimal height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nThe triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
