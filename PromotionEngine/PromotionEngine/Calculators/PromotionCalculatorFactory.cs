using PromotionEngine.Calculators;
using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine
{
    class PromotionCalculatorFactory
    {
        public static PromotionCalculator GetPromotionCalculator(PromotionType type)
        {
            switch (type)
            {
                case PromotionType.AQuantity:
                    IDictionary<SkuType, decimal> skuA = new Dictionary<SkuType, decimal>()
                    {
                        { SkuType.A, 3}
                    };
                    return new AQuantityCalculator(skuA, 130, true);

                case PromotionType.BQuantity:
                    IDictionary<SkuType, decimal> skuB = new Dictionary<SkuType, decimal>()
                    {
                        { SkuType.B, 2}
                    };
                    return new BQuantityCalculator(skuB, 45, true);

                case PromotionType.CDQuantity:
                    IDictionary<SkuType, decimal> skuCD = new Dictionary<SkuType, decimal>()
                    {
                        { SkuType.C, 1},
                        { SkuType.D, 1}
                    };
                    return new CDQuantityCalculator(skuCD, 30, true);
                default:
                    return null;
            }
        }
    }
}
