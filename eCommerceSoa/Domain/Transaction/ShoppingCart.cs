using System;
using Domain.Master.Customer;
using Domain.Master.Product;

namespace Domain.Transaction
{
    public class ShoppingCart
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
