using System;
using System.Collections.Generic;
using eCommerceSoa.Domain.Common;
using eCommerceSoa.Domain.Master.Coupon;
using eCommerceSoa.Domain.Master.Customer;

namespace eCommerceSoa.Domain.Transaction.Cart
{
    public class Order
    {
        public long OrderId { get; private set; }
        public DateTime Date { get; set; }

        public IList<OrderLineItem> LineItems { get; set; }

        public decimal SalesTax { get; set; }
        public decimal SubTotal { get; set; }

        public ShippingMethod Shipping { get; set; }
        public decimal ShippingCost { get; set; }

        public decimal Total { get; set; }


        public CustomerAddress BillingAddress { get; set; }
        public CustomerAddress ShippingAddress { get; set; }

        public IList<OrderPayment> Payments { get; set; }
        
        public IList<CouponTransaction> CouponsApplied { get; set; }
    }
}
