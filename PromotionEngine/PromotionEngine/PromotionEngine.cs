using PromotionEngine.Calculators;
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
        public PromotionEngine(IList<OrderLine> orderLines)
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

            OrderLines = orderLines;
        }

        public decimal Calculate()
        {
            decimal totalPrice = 0m;
            PromotionCalculator calculator;
            PromotionType[] promotionTypes = { PromotionType.AQuantity, PromotionType.BQuantity, PromotionType.CDQuantity };

            if (this.OrderLines == null || this.OrderLines.Count == 0)
                return 0m;

            //Apply promotion calculations
            foreach (PromotionType type in promotionTypes)
            {
                calculator = PromotionCalculatorFactory.GetPromotionCalculator(type);
                totalPrice += calculator.Calculate(this.OrderLines);
            }

            //Calculate for remaining Skus after applying promotion calculation
            foreach (OrderLine order in this.OrderLines)
            {
                decimal price = this.SkuPrices[order.Sku];
                totalPrice += order.Quantity * price;
            }

            return totalPrice;
        }

        static void Main(string[] args)
        {
            //Scenario A
            IList<OrderLine> orderLines = PromotionEngine.GetOrderLines("A");
            PromotionEngine scenarioA = new PromotionEngine(orderLines);
            Console.WriteLine($"Scenario A - Total : {scenarioA.Calculate()}");

            //Scenario B
            orderLines = PromotionEngine.GetOrderLines("B");
            PromotionEngine scenarioB = new PromotionEngine(orderLines);
            Console.WriteLine($"Scenario B - Total : {scenarioB.Calculate()}");

            //Scenario C
            orderLines = PromotionEngine.GetOrderLines("C");
            PromotionEngine scenarioC = new PromotionEngine(orderLines);
            Console.WriteLine($"Scenario C - Total : {scenarioC.Calculate()}");

            Console.ReadLine();
        }

        public static IList<OrderLine> GetOrderLines(string scenario)
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
