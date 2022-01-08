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

        [DataTestMethod]
        [DataRow(8, 40, 320)]
        public void CalculateSalary_ReturnSalary(int num1, int num2, double expected)
        {
            //Act
            var result = _target.DetermineSalary(num1, num2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(9, 77, "error")]
        [DataRow(6, 43, "error")]
        public void CalculateSalary_ReturnError(int num1, int num2, string expected)
        {
            //Act
            var result = Assert.ThrowsException<Exception>(() => _target.DetermineSalary(num1, num2));

            //Assert
            Assert.AreEqual(expected, result.Message);
        }
    }
}
