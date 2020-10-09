using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine
{
    class PromotionEngine
    {
        internal IList<PromotionType> Promotions { set; get; }

        public IList<OrderLine> OrderLines { get; set; }

        //Constructor
        public PromotionEngine(string scenario)
        {
            Promotions = new List<PromotionType>()
            {
                PromotionType.AQuantity,
                PromotionType.BQuantity,
                PromotionType.CDQuantity
            };
        }

        static void Main(string[] args)
        {
        }
    }
}
