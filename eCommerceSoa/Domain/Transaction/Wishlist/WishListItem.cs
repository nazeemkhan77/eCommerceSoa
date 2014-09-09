using System;
using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Domain.Transaction.Cart
{
    public class WishListItem
    {
        public long Id { get; set; }
        public Wishlist.WishList WishList { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public DateTime DateAdded { get; set; }
    }
}