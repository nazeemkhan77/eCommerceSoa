using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Interface.Facade
{
    public interface IProductService
    {
        long AddProduct(Product product);
        void UpdateProduct(Product product);
        void RemoveProduct(long productId);
        //back order
        //etc.
    }
}
