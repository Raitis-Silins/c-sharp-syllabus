using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCount.Tests
{
    [TestClass]
    public class CalculateTests
    {
        private Calculate _target;

        [TestMethod]
        public void CalculateLinesInText_InputWith2Lines_Expected2()
        {
            //Arrange
            var text = "My name is Raitis \n and I live in Tokyo.";
            var expected = 2;
            _target = new Calculate(text);

            //Act
            var result = _target.LinesInText();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateWordsInText_InputWith4Words_Expected4()
        {
            //Arrange
            var text = "My name is Raitis";
            var expected = 4;
            _target = new Calculate(text);

            //Act
            var result = _target.WordsInText();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateCharsInText_InputWith17Chars_Expected17()
        {
            //Arrange
            var text = "I want my chicken";
            var expected = 17;
            _target = new Calculate(text);

            //Act
            var result = _target.CharsInText();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
