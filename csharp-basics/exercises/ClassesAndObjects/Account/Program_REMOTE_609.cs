using System;

namespace Account
{
    class Program
    {
        private static void Main()
        {
            Account firstAccount = new Account("First Account", 100.00);
            firstAccount.Deposit(20.00);
            Console.WriteLine(firstAccount);

            Account codelex = new Account("Sandris", 5100);
            codelex.Withdrawal(100);
            Console.WriteLine(codelex);
            Account myacc = new Account("Mans profils", 0);
            myacc.Deposit(100);
            Console.WriteLine(myacc);

            Account aAcc = new Account("A", 100);
            Account bAcc = new Account("B", 0);
            Account cAcc = new Account("C", 0);

            Transfer(aAcc, bAcc, 50);
            Transfer(bAcc, cAcc, 25);

            Console.WriteLine(aAcc);
            Console.WriteLine(bAcc);
            Console.WriteLine(cAcc);

        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}