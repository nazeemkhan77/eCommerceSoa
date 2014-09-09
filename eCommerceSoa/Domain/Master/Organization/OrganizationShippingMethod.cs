using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Organization
{
    public class OrganizationShippingMethod : ShippingMethod
    {
        public Organization Organization { get; set; }
    }
}
