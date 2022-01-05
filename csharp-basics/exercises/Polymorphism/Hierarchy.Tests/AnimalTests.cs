using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hierarchy.Tests
{
    [TestClass]
    public class AnimalTests
    {
        private List<Food> _food;
        private Cat _cat = new Cat("Pica", "cat", 8, 5, "Home", "Default");
        private Tiger _tiger = new Tiger("Kebab", "Tiger", 70, 15, "Asia");

        [TestInitialize]
        public void Setup()
        {
            _food = new List<Food>() { new Vegetable(6), new Meat(12) };
        }

        [TestMethod]
        public void MakeSound_StringAsSound_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual("meow meow", _cat.MakeSound());
            Assert.AreEqual("ROAAR!!!!", _tiger.MakeSound());
        }

        [TestMethod]
        public void ToString_AnimalToString_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual("cat [Pica, Default, 8, Home, 5]", _cat.ToString());
            Assert.AreEqual("Tiger [Kebab, 70, Asia, 15]", _tiger.ToString());
        }

        [TestMethod]
        public void DisplayAnimal_Display_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual("cat Pica 8 Home Default", _cat.DisplayAnimal());
            Assert.AreEqual("Tiger Kebab 70 Asia", _tiger.DisplayAnimal());
        }

        [TestMethod]
        public void Eat_Meat12_ReturnQuantity()
        {
            //Arrange
            var foodGiven = _food[1];
            var catExpected = "cat [Pica, Default, 8, Home, 17]";
            var tigerExpected = "Tiger [Kebab, 70, Asia, 27]";

            //Act
            var catResult = _cat.Eat(foodGiven);
            var tigerResult = _tiger.Eat(foodGiven);

            //Assert
            Assert.AreEqual(catExpected, catResult);
            Assert.AreEqual(tigerExpected, tigerResult);
        }

        [TestMethod]
        public void Eat_GiveVegetableForTiger_ReturnStringError()
        {
            //Arrange
            var foodGiven = _food[0];
            var expected = "Tiger are not eating that type of food!";

            //Act
            var result = _tiger.Eat(foodGiven);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_VegetableAndMeatEaten_ReturnStringQuantity()
        {
            //Arrange
            var vegetable = new Vegetable(6);
            var meat = new Meat(12);
            var meatToString = "Meat 12";
            var vegetableToString = "Vegetable 6";

            //Act
            var meatResult = meat.ToString();
            var vegetableResult = vegetable.ToString();

            //Assert
            Assert.AreEqual(meatToString, meatResult);
            Assert.AreEqual(vegetableToString, vegetableResult);
        }
    }
}
