using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class DragRaceTests
    {
        private ICar _audi;
        private ICar _bmw;
        private ICar _lada;
        private ICar _lexus;
        private ICar _tesla;
        private ICar _volvo;

        [TestInitialize]
        public void Setup()
        {
            _audi = new Audi();
            _bmw = new Bmw();
            _lada = new Lada();
            _lexus = new Lexus();
            _tesla = new Tesla();
            _volvo = new Volvo();
        }

        [TestMethod]
        public void SpeedUp_SpeedUpCars_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual(10, _audi.SpeedUp());
            Assert.AreEqual(10, _bmw.SpeedUp());
            Assert.AreEqual(50, _lada.SpeedUp());
            Assert.AreEqual(10, _lexus.SpeedUp());
            Assert.AreEqual(15, _tesla.SpeedUp());
            Assert.AreEqual(5, _volvo.SpeedUp());
        }

        [TestMethod]
        public void SlowDown_SlowDownCars_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual(-10, _audi.SlowDown());
            Assert.AreEqual(-10, _bmw.SlowDown());
            Assert.AreEqual(-50, _lada.SlowDown());
            Assert.AreEqual(-10, _lexus.SlowDown());
            Assert.AreEqual(-15, _tesla.SlowDown());
            Assert.AreEqual(-5, _volvo.SlowDown());
        }

        [TestMethod]
        public void ShowCurrentSpeed_ShowCarSpeed_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual("0", _audi.ShowCurrentSpeed());
            Assert.AreEqual("0", _bmw.ShowCurrentSpeed());
            Assert.AreEqual("0", _lada.ShowCurrentSpeed());
            Assert.AreEqual("0", _lexus.ShowCurrentSpeed());
            Assert.AreEqual("0", _tesla.ShowCurrentSpeed());
            Assert.AreEqual("0", _volvo.ShowCurrentSpeed());
        }

        [TestMethod]
        public void StartEngine_StartCarsEngine_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual("Rrrrrrr.....", _audi.StartEngine());
            Assert.AreEqual("Rrrrrrr.....", _bmw.StartEngine());
            Assert.AreEqual("--- vrummmmm ---", _lada.StartEngine());
            Assert.AreEqual("Rrrrrrr.....", _lexus.StartEngine());
            Assert.AreEqual("-- silence ---", _tesla.StartEngine());
            Assert.AreEqual("--- Brr brr brr ---", _volvo.StartEngine());
        }
    }
}
