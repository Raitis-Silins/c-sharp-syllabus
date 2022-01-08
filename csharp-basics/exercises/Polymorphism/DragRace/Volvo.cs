namespace DragRace
{
    public class Volvo : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
            return _currentSpeed += 5;
        }

        public int SlowDown()
        {
            return _currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "--- Brr brr brr ---";
        }

        public int UseNitrousOxideEngine()
        {
            return _currentSpeed += 100;
        }
    }
}
