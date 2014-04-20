using System;

namespace Domain
{
    public class ShoppingCart
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public short Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
