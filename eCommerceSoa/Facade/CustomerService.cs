using eCommerceSoa.BusinessLayer.Contract;
using eCommerceSoa.DataAccess.Contract;
using eCommerceSoa.Domain.Master.Customer;

namespace eCommerceSoa.Business
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //validation annotation goes here
        //transaction annotation goes here
        public void AddNewCustomer(Customer customer)
        {
            _customerRepository.Create(customer);
        }

        //validation annotation goes here
        //transaction annotation goes here
        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
        }
    }
}
