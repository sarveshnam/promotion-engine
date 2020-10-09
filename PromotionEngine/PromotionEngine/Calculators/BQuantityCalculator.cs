using PromotionEngine.Calculators;
using PromotionEngine.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class BQuantityCalculator : PromotionCalculator
    {
        //Constructor  
        public BQuantityCalculator(IDictionary<SkuType, decimal> sku, decimal price, bool isActive): base(sku, price, isActive)
        {
        }
    }
}
