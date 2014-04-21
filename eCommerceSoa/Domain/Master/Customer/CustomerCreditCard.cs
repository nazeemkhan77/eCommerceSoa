using eCommerceSoa.Domain.Master.Payment;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerCreditCard : CreditCard
    {
        public Customer Customer { get; set; }
        public short CustomerCreditCardId { get; set; }
    }
}