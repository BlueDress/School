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

        [Route("customers/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("customers/create")]
        public IActionResult Create(CreateCustomerModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.customersService.Create(model.Name, model.BirthDate, model.IsYoungDriver);

            return Redirect("/customers/all/ascending");
        }

        [Route("customers/edit/{id}")]
        public IActionResult Edit(int id)
        {
            if (!this.customersService.CustomerExists(id))
            {
                return Redirect("/customers/all/ascending");
            }

            var customer = this.customersService.ById(id);

            if (customer == null)
            {
                return Redirect("/customers/all/ascending");
            }

            var custommerToEdit = new EditCustomerModel
            {
                Name = customer.Name,
                BirthDate = customer.BirthDate
            };

            return View(custommerToEdit);
        }

        [HttpPost]
        [Route("customers/edit/{id}")]
        public IActionResult Edit(int id, EditCustomerModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.customersService.Edit(id, model.Name, model.BirthDate);

            return Redirect("/customers/all/ascending");
        }

        [Route("customers/all/{orderType}")]
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

        [Route("customers/{id}")]
        public IActionResult CustomerSales(int id)
        {
            var customer = this.customersService.GetCustomerSales(id);

            return View(customer);
        }
    }
}
