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

        public override decimal Calculate(IList<OrderLine> orderLines)
        {
            decimal total = 0m;
            if (orderLines == null || orderLines.Count == 0)
                return 0m;

            //TODO: Need to add rest of the logic here
            return total;
        }
    }
}
