using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise8.Tests
{
    [TestClass]
    public class SalaryTests
    {
        private Salary _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Salary();
        }

        [TestMethod]
        public void CalculateSalary_Input40and8_ReturnSalary()
        {
            // Arrange
            var hours = 40;
            var pay = 8;
            var salary = hours * pay;

            //Act
            var result = _target.DetermineSalary(pay, hours);

            // Assert
            Assert.AreEqual(result, salary);
        }

        [TestMethod]
        public void CalculateSalary_BasePayUnder8_ReturnError()
        {
            // Arrange
            var expected = "error";

            // Assert
            var exception = Assert.ThrowsException<Exception>(() => _target.DetermineSalary(5, 40));
            Assert.AreEqual(expected, exception.Message);
        }

        [TestMethod]
        public void CalculateSalary_MaxHoursMoreThan60_ReturnError()
        {
            // Arrange
            var expected = "error";

            // Assert
            var exception = Assert.ThrowsException<Exception>(() => _target.DetermineSalary(8, 65));
            Assert.AreEqual(expected, exception.Message);
        }
    }
}
