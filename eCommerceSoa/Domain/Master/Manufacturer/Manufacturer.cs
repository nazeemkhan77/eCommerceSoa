using System.Collections.Generic;

namespace eCommerceSoa.Domain.Master.Manufacturer
{
    public class Manufacturer
    {
        public long ManufacturerId { get; private set; }
        public string Name { get; set; }
        public IList<Domain.Master.Product.Product> Products { get; set; }
        public IList<Shipping> Shippings { get; set; }
    }
}