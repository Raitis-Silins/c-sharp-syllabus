using System;

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            FuelGauge fuel = new FuelGauge(0);
            Odometer odo = new Odometer(0, fuel);

            Console.Write("Fill the tank ");
            var userInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                fuel.IncrementFuel();
                fuel.ShowLiters();
            }

            while (fuel.ActualLiters != 0)
            {
                odo.Increment();
                Console.Write("Fuel tank now: ");
                fuel.ShowLiters();
                Console.WriteLine();
                odo.Decrement();
                Console.Write("Km now: ");
                odo.DisplayMileage();
            }

            Console.WriteLine("Out of fuel");
        }
    }
}