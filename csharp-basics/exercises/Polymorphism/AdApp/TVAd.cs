namespace AdApp
{
    public class TVAd : Advert
    {
        private int _airTime;
        private int _costPerSecond;
        private bool _peakTime;
        public TVAd(int fee, int airTime, int costPerSecond, bool peakTime) : base(fee)
        {
            _airTime = airTime;
            _peakTime = peakTime;
            _costPerSecond = costPerSecond;
        }

        public new int Cost()
        {
            if (_peakTime == true)
            {
                return _airTime * _costPerSecond * 2 + base.Cost();
            }

            return _airTime * _costPerSecond + base.Cost();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}