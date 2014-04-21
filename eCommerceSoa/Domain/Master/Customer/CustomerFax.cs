using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerFax : Fax
    {
        public Customer Customer { get; protected set; }
    }
}
