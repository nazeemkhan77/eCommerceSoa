using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Organization
{
    public class OrganizationPhone : Phone
    {
        public Organization Organization { get; set; }
    }
}
