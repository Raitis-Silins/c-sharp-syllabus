using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Product _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Product("X-massSocks", 0.50, 3);
        }

        [TestMethod]
        public void PrintProduct_ProductString_ShoudlReturnString()
        {
            //Arrange
            var expected = "X-massSocks, price 0,5 EUR, amount 3 units";

            //Act
            var result = _target.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangeQuantity_Quantity_ShoudlReturnQuantity()
        {
            //Arrange
            var expected = 63;
            //Act
            var result = _target.ChangeQuantity(expected);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangePrice_Price_ShoudlReturnPrice()
        {
            //Arrange
            var expected = 19.99;
            //Act
            var result = _target.ChangePrice(expected);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
