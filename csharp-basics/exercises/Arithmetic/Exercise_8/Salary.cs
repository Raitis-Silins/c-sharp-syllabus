using System;

public class Salary
{
    public double DetermineSalary(double basePay, double hoursWorked)
    {
        if (basePay < 8)
        {
            throw new Exception("error");
        }

        if (hoursWorked > 60)
        {
            throw new Exception("error");
        }

        if (hoursWorked > 40)
        {
            return Math.Round(basePay * 40 + (double)1.5 * basePay * (hoursWorked - 40), 2);
        }

        return Math.Round(basePay * hoursWorked, 2);
    }
}