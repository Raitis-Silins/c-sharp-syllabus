using System;

namespace Exercise_8
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base pay rate");
            double basePay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many hours worked");
            double hoursWorked = double.Parse(Console.ReadLine());

            var calculate = new Salary();
            double totalPay = 0;
            
            totalPay = calculate.DetermineSalary(basePay, hoursWorked);
            Console.WriteLine($"Your salary is {totalPay}");
        }
    }
}