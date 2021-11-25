using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter person's weight");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter person's height");
            double height = double.Parse(Console.ReadLine());

            double toPounds = weight * 2.2;
            double toInches = height * 0.393700787;
            double personBMI = (toPounds * 703) / (toInches * toInches);
            double fixBMI = Math.Floor(personBMI * 100) / 100;

            if (fixBMI >= 18.5 && fixBMI <= 25)
                Console.WriteLine("Persons BMI is {0} and the weight is considered optimal", fixBMI);
            if (fixBMI < 18.5)
                Console.WriteLine("Persons BMI is {0} and the weight is considered underweight", fixBMI);
            if (fixBMI > 25)
                Console.WriteLine("Persons BMI is {0} and the weight is considered overweight.", fixBMI);
        }
    }
}
