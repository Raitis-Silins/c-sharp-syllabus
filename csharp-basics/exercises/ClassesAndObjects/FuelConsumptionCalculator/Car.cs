namespace FuelConsumptionCalculator
{
    public class Car
    {
        double _startKilometers;
        double _endKilometers;
        double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;

        }

        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        public double ConsumptionPer100Km()
        {
            return (_liters * 100) / (_endKilometers - _startKilometers);
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }
    }
}
