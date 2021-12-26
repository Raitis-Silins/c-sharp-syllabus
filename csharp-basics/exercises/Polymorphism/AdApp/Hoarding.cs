namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;
        
        public Hoarding(int fee, int numDays, int rate) 
            : base(fee)
        {
            _numDays = numDays;
            _rate = rate;
        }

        public override int Cost()
        {
            return _numDays * _rate + base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}