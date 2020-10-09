using PromotionEngine.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Calculators
{
    abstract class PromotionCalculator
    {
        public PromotionType Type { get; }
        public IDictionary<SkuType, decimal> Sku { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public PromotionCalculator(IDictionary<SkuType, decimal> sku, decimal price, bool isActive)
        {
            this.Type = PromotionType.AQuantity;
            this.Sku = sku;
            this.Price = price;
            this.IsActive = isActive;
        }

        //Provided basic implementation for promotion calculation
        //This calculation is applicable for Promotion on skus A and B
        //For the promotion based on skus C and D, the implementation is provided in CDQuantityCalculator
        public virtual decimal Calculate(IList<OrderLine> orderLines)
        {
            decimal total = 0m;
            if (orderLines == null || orderLines.Count == 0 || !this.IsActive)
                return 0m;

            foreach (var s in this.Sku)
            {
                OrderLine orderLineSku = orderLines.Where(o => o.Sku == s.Key).FirstOrDefault();
                if (orderLineSku != null)
                {
                    int promotionSets = (int)(orderLineSku.Quantity / s.Value);
                    total = promotionSets * this.Price;
                    orderLineSku.Quantity -= promotionSets * s.Value;
                }
            }
            return total;
        }
    }
}
