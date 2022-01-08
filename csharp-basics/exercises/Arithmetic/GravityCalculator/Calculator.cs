using System;

namespace GravityCalculator
{
    public class Calculator
    {
        public double CalculateGravity(double gravity,double fallingTime, double initialPosition, double initialVelocity)
        {
            return 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
        }
    }
}