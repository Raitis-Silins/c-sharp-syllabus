namespace Firm
{
    class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,
            double commissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
            _totalSales = 0;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales * _commissionRate;
        }
    }
}
