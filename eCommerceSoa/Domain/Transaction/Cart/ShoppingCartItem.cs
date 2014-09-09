using System;
using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Domain.Transaction.Cart
{
    public class ShoppingCartItem
    {
        public long Id { get; set; }
        public ShoppingCart Cart { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime DateAdded { get; set; }
    }
}