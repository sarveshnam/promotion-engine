using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngine.Tests
{
    [TestClass]
    public class PromotionCalculatorTest
    {
        [TestMethod]
        public void ScenarioATest()
        {
            //Arrange
            PromotionEngine engine = new PromotionEngine("A");

            //Act
            decimal actualTotal = engine.Calculate();

            //Assert
            decimal expectedTotal = 100;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void ScenarioBTest()
        {
            //Arrange
            PromotionEngine engine = new PromotionEngine("B");

            //Act
            decimal actualTotal = engine.Calculate();

            //Assert
            decimal expectedTotal = 370;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void ScenarioCTest()
        {
            //Arrange
            PromotionEngine engine = new PromotionEngine("C");

            //Act
            decimal actualTotal = engine.Calculate();

            //Assert
            decimal expectedTotal = 280;
            Assert.AreEqual(expectedTotal, actualTotal);
        }
    }
}
