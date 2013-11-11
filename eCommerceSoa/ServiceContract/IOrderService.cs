using System.ServiceModel;

namespace eCommerceSoa.ServiceContract
{
    [ServiceContract]
    public interface IOrderService
    {
        void AddCart();
        void UpdateCart();
        void RetrieveCart();
        void RemoveCart();

        void AddWishlist();
        void UpdateWishlist();
        void RetrieveWishlist(); 
        void RemoveWishlist();

        void ConvertCartToOrder();

        void ProcessOrder();
        void GetOrder();
        void UpdateOrder();
        void RemoveOrder();
    }
}
