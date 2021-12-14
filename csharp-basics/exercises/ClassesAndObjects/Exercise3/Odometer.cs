using System;

namespace Exercise3
{
    class Odometer
    {
        private double _mileage;
        private FuelGauge _actualLiters;

        public Odometer(double mileage, FuelGauge actualLiters)
        {
            _mileage = mileage;
            _actualLiters = actualLiters;
        }

        public void DisplayMileage()
        {
            Console.WriteLine(_mileage);
        }

        public void Increment()
        {
            if (_mileage <= 999999)
            {
                _mileage++;
            }
            else
            {
                _mileage = 0;
            }
        }

        public void Decrement()
        {
            if (_mileage % 10 == 0)
            {
                _actualLiters.DecrementFuel();
            }
        }
    }
}