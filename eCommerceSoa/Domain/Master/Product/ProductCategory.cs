namespace Domain.Master.Product
{
    public class ProductCategory
    {
        public long ProductCategoryId { get; private set; }
        public ProductCategory Parent { get; set; }
        public long Name { get; set; }
    }
}
