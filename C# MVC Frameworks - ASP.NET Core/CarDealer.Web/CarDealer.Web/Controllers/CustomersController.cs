using CarDealer.Services;
using CarDealer.Services.Models;
using CarDealer.Web.Models.CustomersModel;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerService customersService;

        public CustomersController(ICustomerService customerService)
        {
            this.customersService = customerService;
        }

        public IActionResult All(string orderType)
        {
            var order = orderType.ToLower().Equals("ascending") ? OrderType.Ascending : OrderType.Descending;

            var customers = this.customersService.OrderedCustomers(order);
            
            return View(new AllCustomersModel
            {
                Customers = customers,
                OrderType = order
            });
        }
    }
}
