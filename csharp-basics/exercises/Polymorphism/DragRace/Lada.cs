namespace DragRace
{
    public class Lada : ICar
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
            return _currentSpeed += 50;
        }

        public int SlowDown()
        {
            return _currentSpeed -= 50;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "--- vrummmmm ---";
        }
    }
}
