using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class RandomArrayTests
    {
        private RandomArray _target;
        private readonly int[] _testArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestInitialize]
        public void Setup()
        {
            _target = new RandomArray();
        }

        [TestMethod]
        public void CreateArray_ArrayOf10RandomIntegers()
        {
            //Arrange
            var expected = 10;

            //Act
            var result = _target.CreateArray(expected);

            //Assert
            Assert.AreEqual(expected, result.Length);
        }

        [TestMethod]
        public void ArrayClone_CopyOfAnArray_ShouldChangeLastIndex()
        {

            //Act
            var result = _target.ArrayClone(_testArray);

            //Assert
            CollectionAssert.AreNotEqual(_testArray, result);
        }

        [TestMethod]
        public void DisplayArray_ShouldReturnArrayToString()
        {
            //Act
            var result = _target.DisplayArray(_testArray);

            //Assert
            Assert.AreEqual(string.Join(" ", _testArray), result);
        }
    }
}
