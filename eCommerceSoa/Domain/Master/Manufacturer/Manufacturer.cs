using System.Collections.Generic;

namespace eCommerceSoa.Domain.Master.Manufacturer
{
    public class Manufacturer
    {
        public long Id { get; private set; }
        public string Name { get; set; }
        public IList<Product.Product> Products { get; set; }
    }
}