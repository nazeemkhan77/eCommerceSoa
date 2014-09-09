using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.BusinessLayer.Contract
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void RemoveProduct(long productId);
        //back order
        //etc.
    }
}
