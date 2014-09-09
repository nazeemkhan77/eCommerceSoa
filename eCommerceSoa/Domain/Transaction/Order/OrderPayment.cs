using System;
using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Transaction.Cart
{
    public class OrderPayment
    {
        public long Id { get; private set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        //TBD
        public PaymentMethod PaymentMethod { get; set; }

        public string PaymentSystemCode { get; set; }
        public string PaymentAuthorizationCode { get; set; }
    }
}