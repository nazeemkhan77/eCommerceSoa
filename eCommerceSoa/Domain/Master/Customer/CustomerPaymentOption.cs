using System.Collections.Generic;
using eCommerceSoa.Domain.Master.Payment;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerPaymentOption
    {
        public long Id { get; set; }
        //public PaymentType Type { get; set; }

        public Customer Customer { get; set; }

        public IList<CustomerCreditCard> CreditCards { get; set; }
        public IList<CustomerBankAccount> BankAccounts { get; set; }
    }
}