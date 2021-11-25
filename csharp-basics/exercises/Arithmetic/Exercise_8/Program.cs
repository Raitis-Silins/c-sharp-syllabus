using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++, Console.WriteLine())
            {
                Console.WriteLine("For Employee Number: " + i);
                Console.WriteLine("Enter Base Pay:");
                double basePay = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hours Worked:");
                double hoursWorked = double.Parse(Console.ReadLine());
                determineSalary(hoursWorked, basePay);
            }
        }

        public static void determineSalary(double hoursWorked, double basePay)
        {
            if (hoursWorked > 60 || basePay < 8)
            {
                Console.WriteLine("error");
            } else if (hoursWorked <= 40)
            {
                Console.WriteLine(hoursWorked * basePay);
            } else if (hoursWorked > 40)
            {
                double pay = 40 * basePay;
                double nextBasePay = 1.5 * basePay;
                double extraHours = hoursWorked - 40;

                double secondPay = extraHours * nextBasePay;
                decimal salary = (decimal)(pay + secondPay);
                Console.WriteLine("Your total salary is $ {0}", salary);
            }
        }
    }
}