using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerEmail : Email
    {
        public Customer Customer { get; protected set; }
    }
}
