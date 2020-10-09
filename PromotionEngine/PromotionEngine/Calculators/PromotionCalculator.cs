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

        public virtual decimal Calculate(IList<OrderLine> orderLines)
        {
            decimal total = 0m;
            //TODO: Need to write logic here
            return total;
        }
    }
}
