using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass]
    public class DateTests
    {
        private Date _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Date(2, 16, 1993);
        }

        [TestMethod]
        public void DisplayDate_Input_ShouldturnDate()
        {
            //Arrange
            var expected = "2/16/1993";

            //Act
            var result = _target.DisplayDate();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
