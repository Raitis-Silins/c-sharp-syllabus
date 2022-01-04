using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        private Account _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Account("DaveBarada",5000);
        }

        [TestMethod]
        public void Withdrawal_Input100_ShouldReturn4900()
        {
            //Arrange
            var expected = 4900;

            //Act
            var result = _target.Withdrawal(100);

            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void Deposit_Input5000_ShouldReturn10000()
        {
            //Arrange
            var expected = 10000;

            //Act
            var result = _target.Deposit(5000);

            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void Balance_5000_Expected5000()
        {
            //Arrange
            var expected = 5000;

            //Act
            var result = _target.Balance();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_NameAndBalance_ReturnString()
        {
            //Arrange
            var expected = "DaveBarada: 5000";

            //Act
            var result = _target.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
