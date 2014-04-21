using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Payment
{
    public class CreditCard
    {
        public CreditCardType CardType { get; set; }

        public string CardHolderName { get; set; }

        public string CreditCardNumber { get; set; }
        public string CVVNumber { get; set; }

        public Date ExpirationDate { get; set; }
    }
}