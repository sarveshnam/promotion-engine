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

            OrderLine skuC = orderLines.Where(o => o.Sku == SkuType.C).FirstOrDefault();
            OrderLine skuD = orderLines.Where(o => o.Sku == SkuType.D).FirstOrDefault();

            if (skuC != null && skuD != null && skuC.Quantity != 0 && skuD.Quantity != 0)
            {
                decimal minQuantity = skuC.Quantity <= skuD.Quantity ? skuC.Quantity : skuD.Quantity;
                total = minQuantity * this.Price;
                skuC.Quantity -= minQuantity;
                skuD.Quantity -= minQuantity;
            }
            return total;
        }
    }
}
