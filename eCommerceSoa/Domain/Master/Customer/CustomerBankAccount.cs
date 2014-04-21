using eCommerceSoa.Domain.Master.Payment;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerBankAccount : BankAccount
    {
        public Customer Customer { get; set; }
        public short CustomerBankAccountId { get; set; }
    }
}