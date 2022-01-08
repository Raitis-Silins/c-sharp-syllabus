using GravityCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise7.Tests
{
    [TestClass]
    public class Exercise7Tests
    {
        private Calculator _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Calculator();
        }

        [TestMethod]
        public void Calculate_Position_AfterFalling()
        {
            // Arrange
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double expected = -490.5;

            // Act
            var result =_target.CalculateGravity(gravity, fallingTime, initialPosition, initialVelocity);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
