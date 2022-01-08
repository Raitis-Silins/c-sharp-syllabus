using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IBoostableTests
{
    [TestClass]
    public class IBoostableTests
    {
        private IBoostable _lexus;
        private IBoostable _volvo;

        [TestInitialize]
        public void Setup()
        {
            _lexus = new Lexus();
            _volvo = new Volvo();
        }

        [TestMethod]
        public void UseNitrousOxideEngine_BoostCarsSpeed_ShouldBeEqual()
        {
            //Assert
            Assert.AreEqual(30, _lexus.UseNitrousOxideEngine());
            Assert.AreEqual(100, _volvo.UseNitrousOxideEngine());
        }
    }
}