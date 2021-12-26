using System;

namespace DragRace
{
    class Lada : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 50;
        }

        public void SlowDown()
        {
            _currentSpeed -= 50;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("--- vrummmmm ---");
        }
    }
}
