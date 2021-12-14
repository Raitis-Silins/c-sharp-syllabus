using System;

namespace Exercise3
{
    class FuelGauge
    {
        public double ActualLiters;

        public FuelGauge(double actualLiters)
        {
            ActualLiters = actualLiters;
        }

        public void ShowLiters()
        {
            Console.WriteLine(ActualLiters);
        }

        public void IncrementFuel()
        {
            if (ActualLiters < 70)
                ActualLiters++;
        }

        public void DecrementFuel()
        {
            if (ActualLiters > 0)
            {
                ActualLiters--;
            }
        }
    }
}