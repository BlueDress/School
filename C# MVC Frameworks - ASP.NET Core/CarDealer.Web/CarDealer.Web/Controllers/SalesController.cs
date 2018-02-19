using CarDealer.Services;
using CarDealer.Services.Models;
using CarDealer.Web.Models.SalesModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Security.Claims;

namespace CarDealer.Web.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesService salesService;
        private readonly ILogService logService;

        public SalesController(ISalesService salesService, ILogService logService)
        {
            this.salesService = salesService;
            this.logService = logService;
        }

        [Authorize]
        [Route("sales/add")]
        public IActionResult Add()
        {
            var addSale = this.salesService.GetSaleModel();

            var cars = addSale.Cars.Select(c => new SelectListItem
            {
                Text = $"{c.Make} {c.Model}",
                Value = c.Id.ToString()
            });

            var customers = addSale.Customers.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });

            return View(new AddSale
            {
                Cars = cars,
                Customers = customers
            });
        }

        [Authorize]
        [HttpPost]
        [Route("sales/add")]
        public IActionResult Add(AddSale model)
        {
            if (!ModelState.IsValid)
            {
                var addSale = this.salesService.GetSaleModel();

                var cars = addSale.Cars.Select(c => new SelectListItem
                {
                    Text = $"{c.Make} {c.Model}",
                    Value = c.Id.ToString()
                });

                var customers = addSale.Customers.Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });

                return View(new AddSale
                {
                    Cars = cars,
                    Customers = customers
                });
            }

            var viewModel = this.salesService.GetViewSaleModel(model.SelectedCar, model.SelectedCustomer, model.Discount);

            return RedirectToAction("confirm", viewModel);
        }

        [Authorize]
        [Route("sales/confirm")]
        public IActionResult Confirm(ViewSaleModel model)
        {
            return View(new ConfirmSaleModel
            {
                CustomerId = model.CustomerId,
                CustomerName = model.CustomerName,
                CarId = model.CarId,
                CarMakeModel = model.CarMakeModel,
                Discount = model.Discount,
                Price = model.Price,
                FinalPrice = model.FinalPrice
            });
        }

        [Authorize]
        [HttpPost]
        [Route("sales/confirm")]
        public IActionResult Confirm(ConfirmSaleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
        
            this.salesService.AddSale(model.CarId, model.CustomerId, model.Discount);
            this.logService.Add(User.FindFirst(ClaimTypes.Name).Value, "Add", "Sales", DateTime.Now);

            return Redirect("/sales");
        }

        [Route("sales")]
        public IActionResult All()
        {
            var sales = this.salesService.GetAllSales();

            return View(sales);
        }

        [Route("sales/{id}")]
        public IActionResult SaleDetails(int id)
        {
            var sale = this.salesService.GetSale(id);

            return View(sale);
        }

        [Route("sales/discounted")]
        public IActionResult SalesWithDiscount()
        {
            var sales = this.salesService.GetAllSalesWithDiscount();

            return View(sales);
        }

        [Route("sales/discounted/{discount}")]
        public IActionResult SalesWithSpecificDiscount(int discount)
        {
            var sales = this.salesService.GetAllSalesWithSpecificDiscount(discount);

            return View(sales);
        }
    }
}
