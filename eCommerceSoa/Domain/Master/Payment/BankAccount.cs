namespace eCommerceSoa.Domain.Master.Payment
{
    public class BankAccount
    {
        public int Id { get; private set; }
        public string HolderName { get; set; }

        public BankAccountType Type { get; set; }

        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
    }
}