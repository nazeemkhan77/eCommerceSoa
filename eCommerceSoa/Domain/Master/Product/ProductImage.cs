namespace eCommerceSoa.Domain.Master.Product
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public Product Product { get; set; }
        public int Description { get; set; }
        public int FilePath { get; set; }
        public ProductImageType Type { get; set; }
        public ProductImageSize Size { get; set; }
    }
}
