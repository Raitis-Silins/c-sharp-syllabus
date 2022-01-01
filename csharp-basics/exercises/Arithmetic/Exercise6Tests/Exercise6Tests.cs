using Exercise_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6Tests
{
    [TestClass]
    public class Exercise6Tests
    {
        private CozaLozaWoza _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new CozaLozaWoza();
        }

        [TestMethod]
        public void CheckMultiples_Of5And7_shouldReturnLozaWoza()
        {
            //Assert
            var expected = "LozaWoza ";

            // Act
            var result = _target.CheckByIndex(70);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckMultiples_Of3And7_shouldReturnCozaWoza()
        {
            //Assert
            var expected = "CozaWoza ";

            // Act
            var result = _target.CheckByIndex(21);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckMultiples_Of3And5_shouldReturnCozaLoza()
        {
            //Assert
            var expected = "CozaLoza ";

            // Act
            var result = _target.CheckByIndex(15);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckMultiples_Of7_shouldReturnWoza()
        {
            //Assert
            var expected = "Woza ";

            // Act
            var result = _target.CheckByIndex(7);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckMultiples_Of5_shouldReturnLoza()
        {
            //Assert
            var expected = "Loza ";

            // Act
            var result = _target.CheckByIndex(5);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckMultiples_Of3_shouldReturnCoza()
        {
            //Assert
            var expected = "Coza ";

            // Act
            var result = _target.CheckByIndex(3);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
