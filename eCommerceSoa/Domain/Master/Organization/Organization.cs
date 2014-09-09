using System.Collections.Generic;
using eCommerceSoa.Domain.Common;

namespace eCommerceSoa.Domain.Master.Organization
{
    public class Organization
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public IList<OrganizationAddress> Addresses { get;  set; }
        public IList<Phone> Phones { get; set; }
        public IList<Email> Emails { get; set; }
        public IList<ShippingMethod> ShippingMethods { get; set; }
        public IList<PaymentMethod> PaymentMethods { get; set; }
    }
}
