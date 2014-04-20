namespace Domain.Master.Payment
{
    public class CreditCardType
    {
        public byte CreditCardTypeId { get; private set; }
        public byte Name { get; private set; }
        public PaymentType Type { get; set; }
    }
}