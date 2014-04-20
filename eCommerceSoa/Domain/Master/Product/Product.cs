using System.Collections.Generic;

namespace Domain.Master.Product
{
    public class Product
    {
        public long ProductId { get; private set; }
        public string Name { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal Quantity { get; set; }
        public IList<ProductCategory> Categories { get; set; }
        public Domain.Master.Manufacturer.Manufacturer Manufacturer { get; set; }
        
        //height
        //weight
        //dimension
        //instock or not?
    }
}
