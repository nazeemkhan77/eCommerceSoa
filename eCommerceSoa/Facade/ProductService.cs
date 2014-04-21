using eCommerceSoa.DataAccess;
using eCommerceSoa.Exception.Product;
using eCommerceSoa.Interface.DataAccess;
using eCommerceSoa.Interface.Facade;
using System;

namespace eCommerceSoa.Facade
{
    public class ProductService : IProductService
    {
        private IProductDataAccess _productDataAccess;

        public ProductService()
            : this(new ProductDataAccess())
        {
        }

        public ProductService(IProductDataAccess productDataAccess)
        {
            _productDataAccess = productDataAccess;
        }

        public long AddProduct(Domain.Master.Product.Product product)
        {
            //validation goes here
            return _productDataAccess.Create(product);
        }

        public void UpdateProduct(Domain.Master.Product.Product product)
        {
            //validation goes here
            _productDataAccess.Update(product);
        }

        public void RemoveProduct(long productId)
        {
            if (productId <= 0)
                throw new InvalidProductIdException(productId);

            _productDataAccess.Delete(productId);
        }
    }
}
