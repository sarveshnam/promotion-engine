using PromotionEngine.Entities;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionEngine
    {
        internal IList<PromotionType> Promotions { get; set; }

        internal IDictionary<SkuType, decimal> SkuPrices { get; set; }

        public IList<OrderLine> OrderLines { get; set; }

        //Constructor
        public PromotionEngine(string scenario)
        {
            Promotions = new List<PromotionType>()
            {
                PromotionType.AQuantity,
                PromotionType.BQuantity,
                PromotionType.CDQuantity
            };

            SkuPrices = new Dictionary<SkuType, decimal>()
            {
                {SkuType.A, 50m },
                {SkuType.B, 30m },
                {SkuType.C, 20m },
                {SkuType.D, 15m }
            };

            OrderLines = this.GetOrderLines(scenario);
        }

        public decimal Calculate()
        {
            decimal totalPrice = 0m;
            //TODO: Need to write logic here
            return totalPrice;
        }

        static void Main(string[] args)
        {
            //Scenario A
            PromotionEngine scenarioA = new PromotionEngine("A");
            Console.WriteLine($"Scenario A - Total : {scenarioA.Calculate()}");

            //Scenario B
            PromotionEngine scenarioB = new PromotionEngine("B");
            Console.WriteLine($"Scenario B - Total : {scenarioB.Calculate()}");

            //Scenario C
            PromotionEngine scenarioC = new PromotionEngine("C");
            Console.WriteLine($"Scenario C - Total : {scenarioC.Calculate()}");

            Console.ReadLine();
        }

        private IList<OrderLine> GetOrderLines(string scenario)
        {
            IList<OrderLine> orderLines;
            switch (scenario)
            {
                case "A":
                    orderLines = new List<OrderLine>()
                    {
                        new OrderLine(SkuType.A, 1),
                        new OrderLine(SkuType.B, 1),
                        new OrderLine(SkuType.C, 1)
                    };
                    break;
                case "B":
                    orderLines = new List<OrderLine>()
                    {
                        new OrderLine(SkuType.A, 5),
                        new OrderLine(SkuType.B, 5),
                        new OrderLine(SkuType.C, 1)
                    };
                    break;
                case "C":
                    orderLines = new List<OrderLine>()
                    {
                        new OrderLine(SkuType.A, 3),
                        new OrderLine(SkuType.B, 5),
                        new OrderLine(SkuType.C, 1),
                        new OrderLine(SkuType.D, 1)
                    };
                    break;
                default:
                    orderLines = new List<OrderLine>();
                    break;
            }
            return orderLines;
        }
    }
}
