using System;
using System.Collections.Generic;
using Domain.Master.Customer;

namespace Domain.Transaction
{
    public class Order
    {
        public long OrderId { get; private set; }
        public DateTime Date { get; set; }

        public IList<OrderLineItem> LineItems { get; set; }

        public decimal SalesTaxPercentage { get; set; }
        public decimal SalesTaxTotal { get; set; }
        public decimal GrandShippingTotal { get; set; }
        public decimal GrandOrderTotalPrice { get; set; }

        public CustomerAddress BillingAddress { get; set; }
        public CustomerAddress ShippingAddress { get; set; }

        public IList<OrderPayment> Payments { get; set; }
    }

    public class OrderPayment
    {
        public long OrderPaymentId { get; private set; }
        public string CreditCardType { get; set; }
        public string Last4DigitsCreditCard { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string PaymentSystemCode { get; set; }
        public string PaymentAuthorizationCode { get; set; }
    }
}
