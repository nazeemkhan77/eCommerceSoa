using Domain.Common;

namespace Domain.Master.Customer
{
    public class CustomerPhone : Phone
    {
        public Customer Customer { get; protected set; }
    }
}
