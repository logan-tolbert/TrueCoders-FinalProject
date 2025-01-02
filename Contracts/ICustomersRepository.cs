using WeGotBikes.Models.Sales;

namespace WeGotBikes.Contracts
{
    public interface ICustomersRepository
    {
        List<Customer> GetAllCustomers();
    }
}