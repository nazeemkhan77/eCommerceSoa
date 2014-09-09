using eCommerceSoa.Domain.Master.Customer;

namespace eCommerceSoa.BusinessLayer.Contract
{
    public interface ICustomerService
    {
        void AddNewCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}
