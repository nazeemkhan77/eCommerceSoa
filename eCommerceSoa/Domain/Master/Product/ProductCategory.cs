using System.Collections.Generic;

namespace eCommerceSoa.Domain.Master.Product
{
    public class ProductCategory
    {
        public long Id { get; private set; }
        public long Name { get; set; }

        public ProductCategory Parent { get; set; }

        public IList<Product> Products { get; set; }
    }
}
