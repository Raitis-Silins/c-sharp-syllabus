using Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class Exercise1Tests
    {
        private Check15 _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Check15();
        }

        [TestMethod]
        public void CheckIntegers_Input63and43_ShouldReturnFalse()
        {
            //Arrange
            var num1 = 63;
            var num2 = 43;

            //Act
            var result = _target.CheckIntegers(num1, num2);

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckIntegers_Input15and43_ShouldReturnTrue()
        {
            //Arrange
            var num1 = 15;
            var num2 = 43;

            //Act
            var result = _target.CheckIntegers(num1, num2);

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckIntegers_IfSumIs15_ShouldReturnTrue()
        {
            //Arrange
            var num1 = 10;
            var num2 = 5;

            //Act
            var result = _target.CheckIntegers(num1, num2);

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckIntegers_IfSubtractionIs15_ShouldReturnTrue()
        {
            //Arrange
            var num1 = 31;
            var num2 = 16;

            //Act
            var result1 = _target.CheckIntegers(num1, num2);
            var result2 = _target.CheckIntegers(num2, num1);

            //Assert
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
        }
    }
}
