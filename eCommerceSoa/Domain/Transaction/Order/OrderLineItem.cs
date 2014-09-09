using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Domain.Transaction.Cart
{
    public class OrderLineItem
    {
        public long Id { get; private set; }

        public Product Product { get; set; }
        public decimal Quantity { get; set; }

        public decimal PricePerUnit { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}