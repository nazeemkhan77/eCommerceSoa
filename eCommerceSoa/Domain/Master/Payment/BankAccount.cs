namespace eCommerceSoa.Domain.Master.Payment
{
    public class BankAccount
    {
        public BankAccountType BankAccountType { get; set; }

        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
    }
}