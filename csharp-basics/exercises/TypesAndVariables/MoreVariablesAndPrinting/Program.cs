using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            int age = 35;
            double weight = 180;
            double height = 74;
            const double inchesToCm = 2.54;
            const double poundsToKg = 0.453592;
            double weightInKG = Math.Round(poundsToKg * weight, 2);
            double heightInCM = Math.Round(inchesToCm * height, 2);

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches tall.");
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + heightInCM + ", and " + weightInKG
                               + " I get " + (age + heightInCM + weightInKG) + ".");
            Console.ReadKey();
        }
    }
}