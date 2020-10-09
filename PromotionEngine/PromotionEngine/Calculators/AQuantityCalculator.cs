using PromotionEngine.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Calculators
{
    class AQuantityCalculator : PromotionCalculator
    {
        //Constructor        
        public AQuantityCalculator(IDictionary<SkuType, decimal> sku, decimal price, bool isActive) : base(sku, price, isActive)
        {
        }
    }
}
