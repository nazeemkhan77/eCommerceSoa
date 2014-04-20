namespace Domain
{
    public class Phone
    {
        public Customer Customer { get; private set; }
        public string Type { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public bool IsPrimary { get; set; }
    }
}