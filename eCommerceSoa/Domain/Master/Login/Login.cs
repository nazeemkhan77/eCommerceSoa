using System;

namespace eCommerceSoa.Domain.Master.Login
{
    public class Login
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public Customer.Customer Customer { get; set; }
        public bool Active { get; set; }
    }
}