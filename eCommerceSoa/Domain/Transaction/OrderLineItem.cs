using Domain.Master.Product;

namespace Domain.Transaction
{
    public class OrderLineItem
    {
        public long OrderLineItemId { get; private set; }

        public Product Product { get; set; }
        public decimal Quantity { get; set; }

        public decimal PricePerUnit { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }

        public long ShippingId { get; set; }

        public string TrackingId { get; set; }
    }
}