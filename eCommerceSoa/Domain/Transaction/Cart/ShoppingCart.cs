using System;
using System.Collections.Generic;
using eCommerceSoa.Domain.Master.Customer;

namespace eCommerceSoa.Domain.Transaction.Cart
{
    public class ShoppingCart
    {
        public long Id { get; set; }
        public Customer Customer { get; set; }
        public IList<ShoppingCartItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
