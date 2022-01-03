using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhoneBook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [TestMethod]
        public void PutNumber_Raitis1234567_ShouldContainRaitis()
        {
            //Arrange
            var name = "Raitis";
            var number = "1234567";

            //Act
            _target.PutNumber(name, number);

            //Assert
            Assert.AreEqual(number, _target.GetNumber(name));
        }

        [TestMethod]
        public void GetNumber_Raitis_ShouldBeNull()
        {
            //Act
            var number = _target.GetNumber("Raitis");

            //Assert
            Assert.AreEqual(null, number);
        }

        [TestMethod]
        public void PutNumber_NameIsNull_ThrowsException()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber(null, "123456"));

        }

        [TestMethod]
        public void PutNumber_NumberIsNull_ThrowsException()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber("Raitis", null));

        }
    }
}
