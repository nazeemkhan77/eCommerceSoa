namespace eCommerceSoa.Domain.Common
{
    public class Address
    {
        public int Id { get; set; }
        public AddressType Type { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public string PostalCode { get; set; }
        public string PostalCodeExtenstion { get; set; }
    }
}