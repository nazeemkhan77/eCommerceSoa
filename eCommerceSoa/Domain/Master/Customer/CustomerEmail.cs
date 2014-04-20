using Domain.Common;

namespace Domain.Master.Customer
{
    public class CustomerEmail : Email
    {
        public Customer Customer { get; protected set; }
    }
}
