using System;
using System.Collections.Generic;
using eCommerceSoa.Domain.Master.Customer;
using eCommerceSoa.Domain.Transaction.Cart;

namespace eCommerceSoa.Domain.Transaction.Wishlist
{
    public class WishList
    {
        public long Id { get; set; }
        public Customer Customer { get; set; }
        public IList<WishListItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
