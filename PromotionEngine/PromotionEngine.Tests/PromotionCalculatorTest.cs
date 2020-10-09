using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Tests
{
    [TestClass]
    public class PromotionCalculatorTest
    {
        [TestMethod]
        public void ScenarioATest()
        {
            //Arrange
            IList<OrderLine> orderLines = PromotionEngine.GetOrderLines("A");
            PromotionEngine engine = new PromotionEngine(orderLines);

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
            IList<OrderLine> orderLines = PromotionEngine.GetOrderLines("B");
            PromotionEngine engine = new PromotionEngine(orderLines);

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
            IList<OrderLine> orderLines = PromotionEngine.GetOrderLines("C");
            PromotionEngine engine = new PromotionEngine(orderLines);

            //Act
            decimal actualTotal = engine.Calculate();

            //Assert
            decimal expectedTotal = 280;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void EmptySkusTest()
        {
            //Arrange
            IList<OrderLine> orderLines = PromotionEngine.GetOrderLines("D");
            PromotionEngine engine = new PromotionEngine(orderLines);

            //Act
            decimal actualTotal = engine.Calculate();

            //Assert
            decimal expectedTotal = 0;
            Assert.AreEqual(expectedTotal, actualTotal);
        }
    }
}
