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

        [DataTestMethod]
        [DataRow(70, "LozaWoza ")]
        [DataRow(21, "CozaWoza ")]  
        [DataRow(15, "CozaLoza ")]
        [DataRow(7, "Woza ")]
        [DataRow(5, "Loza ")]
        [DataRow(3, "Coza ")]
        public void CheckMultiples_ShouldReturnExpected(int number,  string expected)
        {
            //Act
            var actual = _target.CheckByIndex(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
