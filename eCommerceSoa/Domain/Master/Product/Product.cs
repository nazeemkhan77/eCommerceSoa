using System.Collections.Generic;

namespace eCommerceSoa.Domain.Master.Product
{
    public class Product
    {
        public Product(long productId)
        {
            ProductId = productId;
        }

        public long ProductId { get; private set; }
        public string Name { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal Quantity { get; set; }

        public IList<ProductCategory> Categories { get; set; }
        public IList<ProductImage> ProductImages { get; set; }
        public IList<ProductReview> Reviews { get; set; }

        public Organization.Organization Organization { get; set; }
        public Manufacturer.Manufacturer Manufacturer { get; set; }

        //product specific properties
        public IList<ProductProperty> Properties { get; set; }
    }
}
