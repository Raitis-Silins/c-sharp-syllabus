using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal _startBalance;
            decimal _annualInterestRate;
            int _months;
            decimal _depositAmount;
            decimal _withdrawAmount;

            Console.Write("How much money is in the account?:  ");
            _startBalance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the annual interest rate:  ");
            _annualInterestRate = decimal.Parse(Console.ReadLine());
            Console.Write("How long has the account been opened?:  ");
            _months = int.Parse(Console.ReadLine());

            SavingsAccount test = new SavingsAccount(startBalance: _startBalance, annualInterestRate: _annualInterestRate);

            for (var i = 0; i < _months; i++)
            {
                Console.Write($"Enter amount deposited for month: {i + 1}  "); 
                _depositAmount = decimal.Parse(Console.ReadLine());

                test.Deposit(_depositAmount); 

                Console.Write($"Enter amount withdrawn for month: {i + 1}  ");
                _withdrawAmount = decimal.Parse(Console.ReadLine());

                test.Withdraw(_withdrawAmount); 
                test.AcquireMonthlyInterest();
            }

            DisplayData(test);
        }

        public static void DisplayData(SavingsAccount test)
        {
            decimal _balance = Math.Round(test.GetBalance() * (decimal)100.0) / (decimal)100.0; 
            decimal _totalInterest = Math.Round(test.GetTotalnterest() * (decimal)100.0) / (decimal)100.0;

            Console.WriteLine();
            Console.WriteLine($"Total deposited: ${test.GetTotalDeposits()}");
            Console.WriteLine($"Total withdrawn: ${test.GetTotalWithdraws()}");
            Console.WriteLine($"Interest earned: ${_totalInterest}");
            Console.WriteLine($"Ending balance: ${_balance}"); 
        }
    }
}
