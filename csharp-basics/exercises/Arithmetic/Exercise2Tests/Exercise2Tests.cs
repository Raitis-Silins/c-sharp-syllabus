using Exercise2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise2Tests
{
    [TestClass]
    public class Exercise2Tests
    {
        private OddEven _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new OddEven();
        }

        [TestMethod]
        public void CheckNumber_Input24_shouldReturnEven()
        {
            // Arrange
            int numberEntered = 24;
            string expected = "Even number";

            // Act
            var result = _target.CheckOddEven(numberEntered);

            // Assert
            Assert.AreEqual(expected, result, true);
        }

        [TestMethod]
        public void CheckNumber_Input3_shouldReturnOdd()
        {
            // Arrange
            int numberEntered = 3;
            string expected = "Odd number";

            // Act
            var result = _target.CheckOddEven(numberEntered);

            // Assert
            Assert.AreEqual(expected, result, true);
        }
    }
}
