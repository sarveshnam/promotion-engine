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

        //The promotion calculation defined in PromotionCalculator is applicable here
        //If the implementation changes in future, override the Calculate method
        //public override decimal Calculate(IList<OrderLine> orderLines)
        //{
        //}
    }
}
