using System;
using eCommerceSoa.Domain.Transaction.Cart;

namespace eCommerceSoa.Domain.Master.Coupon
{
    public class CouponTransaction
    {
        public Coupon Coupon { get; set; }
        public Order Order { get; set; }
        public DateTime DateTime { get; set; }
    }
}
