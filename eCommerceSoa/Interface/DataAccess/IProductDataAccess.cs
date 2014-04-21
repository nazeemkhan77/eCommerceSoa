using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Interface.DataAccess
{
    public interface IProductDataAccess
    {
        long Create(Product product);
        void Update(Product product);
        void Delete(long productId);
        Product Get(long productId);
    }
}
