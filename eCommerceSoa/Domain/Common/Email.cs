namespace eCommerceSoa.Domain.Common
{
    public class Email
    {
        public EmailType Type { get; set; }
        public string EmailAddress { get; set; }
        public bool IsPrimary { get; set; }
    }
}