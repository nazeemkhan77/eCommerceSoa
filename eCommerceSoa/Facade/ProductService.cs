using eCommerceSoa.BusinessLayer.Contract;
using eCommerceSoa.DataAccess.Contract;
using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Business
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        //validation annotation goes here
        public void AddProduct(Product product)
        {
            _productRepository.Create(product);
            _productRepository.Save();
        }

        //validation annotation goes here
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        //validation annotation goes here
        public void RemoveProduct(long productId)
        {
            _productRepository.Delete(new Product(productId));
            _productRepository.Save();
        }
    }
}
