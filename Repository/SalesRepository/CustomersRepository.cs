using WeGotBikes.Contracts;
using WeGotBikes.DataGateway;
using WeGotBikes.Models.Sales;


namespace WeGotBikes.Repository.SalesRepository;

public class CustomersRepository : ICustomersRepository
{
    private readonly IDataAccess _db;

    public CustomersRepository(IDataAccess db)
    {
        _db = db;
    }

    public List<Customer> GetAllCustomers()
    {
        string sqlStatement = @"select * 
                                from sales.customers;
                                ";
        return _db.LoadData<Customer, dynamic>(sqlStatement, new { }, "Default", false).ToList();
    }
}
