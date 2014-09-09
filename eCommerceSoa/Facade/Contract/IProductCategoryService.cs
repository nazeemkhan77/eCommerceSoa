using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.BusinessLayer.Contract
{
    public interface IProductCategoryService
    {
        void AddProductCategory(ProductCategory productCategory);
        void UpdateProductCategory(ProductCategory productCategory);
        void RemoveProductCategory(ProductCategory productCategory);
    }
}
