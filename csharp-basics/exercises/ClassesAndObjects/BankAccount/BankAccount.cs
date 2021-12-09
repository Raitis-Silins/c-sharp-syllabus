using System;

namespace BankAccount
{
    class BankAccount
    {
        public double _balance;
        public string _accountName;

        public BankAccount(string account, double balance)
        {
            _balance = Math.Round(balance, 2);
            _accountName = account;
        }

        public string ShowUserNameAndbalance()
        {
            if (_balance < 0)
            {
                return $"{_accountName}, -${_balance * -1:0.00}";
            }
            return $"{_accountName}, ${_balance:0.00}";
        }
    }
}