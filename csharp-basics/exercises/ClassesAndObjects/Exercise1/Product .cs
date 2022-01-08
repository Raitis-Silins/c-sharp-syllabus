namespace Exercise1
{
    public class Product
    {
        private double _price;
        private int _amount;
        private string _name;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _price = priceAtStart;
            _amount = amountAtStart;
            _name = name;
        }

        public string PrintProduct()
        {
            return $"{_name}, price {_price} EUR, amount {_amount} units";
        }

        public int ChangeQuantity(int quantity)
        {
            return _amount = quantity;
        }

        public double ChangePrice(double price)
        {
            return _price = price;
        }
    }
}
