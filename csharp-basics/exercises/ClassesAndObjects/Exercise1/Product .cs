using System;

namespace Exercise1
{
    class Product
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

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {_price} EUR, amount {_amount} units");
        }

        public void ChangeQuantity(int quantity)
        {
            _amount = quantity;
        }

        public void ChangePrice(double price)
        {
            _price = price;
        }
    }
}
