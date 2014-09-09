namespace eCommerceSoa.Domain.Master.Product
{
    public class ProductReview
    {
        public Customer.Customer Customer { get; set; }
        public Product Product { get; set; }
        public short Rating { get; set; }
        public string Comments { get; set; }
    }
}