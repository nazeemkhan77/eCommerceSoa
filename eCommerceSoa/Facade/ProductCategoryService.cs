using eCommerceSoa.BusinessLayer.Contract;
using eCommerceSoa.DataAccess.Contract;
using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.BusinessLayer
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IRepository<ProductCategory> _productCategoryRepository;

        public ProductCategoryService(IRepository<ProductCategory> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public void AddProductCategory(ProductCategory productCategory)
        {
            _productCategoryRepository.Create(productCategory);
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            _productCategoryRepository.Update(productCategory);
        }

        public void RemoveProductCategory(ProductCategory productCategory)
        {
            _productCategoryRepository.Delete(productCategory);
        }
    }
}
