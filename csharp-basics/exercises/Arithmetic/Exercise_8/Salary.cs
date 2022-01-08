using System;

public class Salary
{
    public double DetermineSalary(double basePay, double hoursWorked)
    {
        if (basePay < 8 || hoursWorked > 60)
        {
            throw new Exception("error");
        }

        return hoursWorked > 40 ? Math.Round(basePay * 40 + (double)1.5 * basePay * (hoursWorked - 40), 2) : Math.Round(basePay * hoursWorked, 2);
    }
}