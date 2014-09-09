namespace eCommerceSoa.Domain.Master.Product
{
    public class ProductProperty
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public Product Product { get; set; }
    }
}