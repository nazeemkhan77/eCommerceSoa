using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Customer
{
    public class CustomerAddress : Address
    {
        /// <summary>
        /// Customer the address is associated
        /// </summary>
        public Customer Customer { get; private set; }

        /// <summary>
        /// Is default address
        /// </summary>
        public bool IsDefault { get; set; }
    }
}
