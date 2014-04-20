using Domain.Common;

namespace Domain.Master.Customer
{
    public class CustomerFax : Fax
    {
        public Customer Customer { get; protected set; }
    }
}
