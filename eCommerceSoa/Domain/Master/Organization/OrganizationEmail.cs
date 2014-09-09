using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Organization
{
    public class OrganizationEmail : Email
    {
        public Organization Organization { get; set; }
    }
}
