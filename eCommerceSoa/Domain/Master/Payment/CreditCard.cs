using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Payment
{
    public class CreditCard
    {
        public long Id { get; private set; }
        public string HolderName { get; set; }

        public CreditCardType Type { get; set; }

        public string Number { get; set; }
        public string CVV { get; set; }

        public Date ExpirationDate { get; set; }
    }
}