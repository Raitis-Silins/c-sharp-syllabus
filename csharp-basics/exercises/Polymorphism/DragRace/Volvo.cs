using System;

namespace DragRace
{
    class Volvo : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 5;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("--- Brr brr brr ---");
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 100;
        }
    }
}
