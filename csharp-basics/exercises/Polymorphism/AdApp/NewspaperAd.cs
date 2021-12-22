namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int rate, int column) : base(fee)
        {
            _rate = rate;
            _column = column;
        }

        public override int Cost()
        {
            var fee = base.Cost();
            return fee + _rate * _column;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}