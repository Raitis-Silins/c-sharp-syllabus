using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal startBalance;
            decimal annualInterestRate;
            int months;
            decimal depositAmount;
            decimal withdrawAmount;

            Console.Write("How much money is in the account?:  ");
            startBalance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the annual interest rate:  ");
            annualInterestRate = decimal.Parse(Console.ReadLine());
            Console.Write("How long has the account been opened?:  ");
            months = int.Parse(Console.ReadLine());

            SavingsAccount test = new SavingsAccount(startBalance: startBalance, annualInterestRate: annualInterestRate);

            for (var i = 0; i < months; i++)
            {
                Console.Write($"Enter amount deposited for month: {i + 1}  ");
                depositAmount = decimal.Parse(Console.ReadLine());

                test.Deposit(depositAmount);

                Console.Write($"Enter amount withdrawn for month: {i + 1}  ");
                withdrawAmount = decimal.Parse(Console.ReadLine());

                test.Withdraw(withdrawAmount);
                test.AcquireMonthlyInterest();
            }

            DisplayData(test);
        }

        public static void DisplayData(SavingsAccount test)
        {
            decimal balance = Math.Round(test.GetBalance() * (decimal)100.0) / (decimal)100.0;
            decimal totalInterest = Math.Round(test.GetTotalnterest() * (decimal)100.0) / (decimal)100.0;

            Console.WriteLine();
            Console.WriteLine($"Total deposited: ${test.GetTotalDeposits()}");
            Console.WriteLine($"Total withdrawn: ${test.GetTotalWithdraws()}");
            Console.WriteLine($"Interest earned: ${totalInterest}");
            Console.WriteLine($"Ending balance: ${balance}");
        }
    }
}
