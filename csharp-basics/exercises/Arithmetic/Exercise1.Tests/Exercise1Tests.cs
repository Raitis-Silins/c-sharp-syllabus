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

        [DataTestMethod]
        [DataRow(10, 5)]
        [DataRow(15, 43)]
        [DataRow(31, 16)]
        [DataRow(10, 25)]
        public void CheckIntegers_If15_ShouldReturnTrue(int a, int b)
        {
            //Act
            var result = _target.CheckIntegers(a, b);

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}
