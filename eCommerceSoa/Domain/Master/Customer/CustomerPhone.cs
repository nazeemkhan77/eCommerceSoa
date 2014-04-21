using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerPhone : Phone
    {
        public Customer Customer { get; protected set; }
    }
}
