using System.Collections.Generic;
using eCommerceSoa.Domain.Master.Payment;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerPaymentOption
    {
        public Customer Customer { get; set; }
        public long CustomerPaymentOptionId { get; set; }
        public PaymentType Type { get; set; }
        public IList<CustomerCreditCard> CreditCards { get; set; }
        public IList<CustomerBankAccount> BankAccounts { get; set; }
    }
}