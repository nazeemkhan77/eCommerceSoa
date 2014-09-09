using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Organization
{
    public class OrganizationAddress : Address
    {
        public Organization Organization { get; set; }
    }
}
