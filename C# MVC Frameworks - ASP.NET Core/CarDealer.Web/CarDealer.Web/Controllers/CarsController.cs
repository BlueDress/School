using CarDealer.Services;
using CarDealer.Web.Models.CarsModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Security.Claims;

namespace CarDealer.Web.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService carService;
        private readonly IPartService partService;
        private readonly ILogService logService;

        public CarsController(ICarService carService, IPartService partService, ILogService logService)
        {
            this.carService = carService;
            this.partService = partService;
            this.logService = logService;
        }

        [Route("cars/parts")]
        public IActionResult CarsWithParts()
        {
            var carsWithParts = this.carService.CarWithParts();

            return View(new CarsWithPartsModel
            {
                CarsWithParts = carsWithParts
            });
        }

        [Authorize]
        [Route("cars/add")]
        public IActionResult Add()
        {
            var parts = this.partService.Parts().Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            });

            return View(new AddCarModel
            {
                Parts = parts
            });
        }

        [Authorize]
        [HttpPost]
        [Route("cars/add")]
        public IActionResult Add(AddCarModel carModel)
        {
            if (!ModelState.IsValid)
            {
                var parts = this.partService.Parts().Select(p => new SelectListItem
                {
                    Text = p.Name,
                    Value = p.Id.ToString()
                });

                return View(new AddCarModel
                {
                    Parts = parts
                });
            }

            this.carService.Add(carModel.Make, carModel.Model, carModel.TravelledDistance, carModel.SelectedParts);
            this.logService.Add(User.FindFirst(ClaimTypes.Name).Value, "Add", "Cars", DateTime.Now);

            return Redirect("/cars/parts");
        }

        [Route("cars/{make}")]
        public IActionResult ByMake(string make)
        {
            var orderedCars = this.carService.ByMake(make);

            return View(new CarsByMakeModel
            {
                Cars = orderedCars,
                Make = make
            });
        }
    }
}
