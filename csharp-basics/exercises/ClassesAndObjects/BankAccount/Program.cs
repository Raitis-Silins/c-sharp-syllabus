using System;

namespace BankAccount
{
    class Program
    {
        static void Main()
        {
            BankAccount benBen = new BankAccount("Benson", 17.25);
            BankAccount test = new BankAccount("test", -17.5);
            Console.WriteLine(benBen.ShowUserNameAndbalance());
            Console.WriteLine(test.ShowUserNameAndbalance());
        }
    }
}
