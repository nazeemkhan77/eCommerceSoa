using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Organization
{
    public class OrganizationPaymentMethod : PaymentMethod
    {
        public Organization Organization { get; set; }
    }
}
