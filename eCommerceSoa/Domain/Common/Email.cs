namespace Domain
{
    public class Email
    {
        public Customer Customer { get; private set; }
        public string Type { get; set; }
        public string EmailAddress { get; set; }
        public bool IsPrimary { get; set; }
    }
}