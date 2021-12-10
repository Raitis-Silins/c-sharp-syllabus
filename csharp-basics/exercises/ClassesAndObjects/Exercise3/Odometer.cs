using System;

namespace Exercise3
{
    class Odometer
    {
        public double Mileage;
        public FuelGauge ActualLiters;

        public Odometer(double mileage, FuelGauge actualLiters)
        {
            Mileage = mileage;
            ActualLiters = actualLiters;
        }

        public void DisplayMileage()
        {
            Console.WriteLine(Mileage);
        }

        public void Increment()
        {
            if (Mileage <= 999999)
            {
                Mileage++;
            }
            else
            {
                Mileage = 0;
            }
        }

        public void Decrement()
        {
            if (Mileage % 10 == 0)
            {
                ActualLiters.DecrementFuel();
            }
        }
    }
}