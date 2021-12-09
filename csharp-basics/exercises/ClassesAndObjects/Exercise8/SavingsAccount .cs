using System;

namespace Exercise8
{
    class SavingsAccount
    {
        private decimal _balance;
        private decimal _annualInterestRate;
        private decimal _totalDeposits;
        private decimal _totalWithdraws;
        private decimal _totalInterest;

        public SavingsAccount(decimal startBalance, decimal annualInterestRate)
        {
            _balance = startBalance;
            _annualInterestRate = annualInterestRate;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            _totalDeposits += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
            _totalWithdraws += amount;
        }

        public void AcquireMonthlyInterest()
        {
            decimal monthlyInterest = _balance * GetMonthlyInterestRate();
            _totalInterest += monthlyInterest;
            _balance += monthlyInterest;
        }

        public decimal GetMonthlyInterestRate()
        {
            return _annualInterestRate / 12;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public decimal GetTotalDeposits()
        {
            return _totalDeposits;
        }

        public decimal GetTotalWithdraws()
        {
            return _totalWithdraws;
        }

        public decimal GetTotalnterest()
        {
            return _totalInterest;
        }
    }
}
