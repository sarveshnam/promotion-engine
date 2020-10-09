namespace PromotionEngine.Entities
{
    public class OrderLine
    {
        public SkuType Sku { get; set; }
        public decimal Quantity { get; set; }

        public OrderLine(SkuType sku, decimal quantity)
        {
            this.Sku = sku;
            this.Quantity = quantity;
        }
    }
}
