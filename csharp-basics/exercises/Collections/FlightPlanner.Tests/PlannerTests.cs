using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlightPlanner.Tests
{
    [TestClass]
    public class PlannerTests
    {
        private Planner _target;

        public PlannerTests()
        {
            var flights = new Dictionary<string, List<string>>
            {
                {"Riga", new List<string> {"Warsaw", "Tallinn"}},
                {"Warsaw", new List<string> {"Riga", "Tallinn"}},
                {"Tallinn", new List<string> {"Riga", "Warsaw"}}
            };
            _target = new Planner(flights);
        }

        [TestMethod]
        public void PrintCity_CityList_ShouldPrintCitiesList()
        {
            //Arrange
            var test = "Riga";

            //Act
            var result = _target.PrintCity();
            ;
            //Assert
            Assert.IsTrue(test.All((e => result.Contains(e))));
        }

        [TestMethod]
        public void StartingCity_City_ShouldContainStartingCity()
        {
            //Arrange
            var test = "Warsaw";
            var expected = $"You're destinations: Riga" + "\n" + "You're destinations: Tallinn" + "\n";

            //Act
            var result = _target.StartingCity(test);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
