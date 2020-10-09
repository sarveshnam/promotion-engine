using PromotionEngine.Calculators;
using PromotionEngine.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class CDQuantityCalculator : PromotionCalculator
    {
        //Constructor
        public CDQuantityCalculator(IDictionary<SkuType, decimal> sku, decimal price, bool isActive) : base(sku, price, isActive)
        {
        }
    }
}
