using Microsoft.AspNetCore.Mvc;
using WeGotBikes.Contracts;
using WeGotBikes.DataGateway;
using WeGotBikes.Models.Sales;

namespace WeGotBikes.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IDataAccess _db;
        private readonly ICustomersRepository _repo;

        public CustomersController(IDataAccess db, ICustomersRepository repo)
        {
            _db = db;
            _repo = repo;
        }

        public IActionResult Index()
        {
            List<Customer> record = _repo.GetAllCustomers(); 
            return View(record);
        }
    }
}
