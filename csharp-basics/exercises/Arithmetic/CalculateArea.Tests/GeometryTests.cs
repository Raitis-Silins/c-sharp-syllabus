using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculateArea.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void AreaOfCircle_Input5_ShouldReturn78Point5()
        {
            //Arrange
            var expected = 78.5;

            //Act
            var result = Math.Round(Geometry.AreaOfCircle(5), 1);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaOfRectangle_Length5Width10_ShouldReturn50()
        {
            //Arrange
            var expected = 50;

            //Act
            var result = Geometry.AreaOfRectangle(5, 10);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaOfTriangle_Length15Height15_ShouldReturn112Point5()
        {
            //Arrange
            var expected = 112.5;

            //Act
            var result = Geometry.AreaOfTriangle(15, 15);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
