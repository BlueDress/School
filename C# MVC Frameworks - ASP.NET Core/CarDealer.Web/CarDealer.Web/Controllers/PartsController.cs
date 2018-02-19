using CarDealer.Services;
using CarDealer.Services.Implementations;
using CarDealer.Services.Models;
using CarDealer.Web.Models.Parts;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    public class PartsController : Controller
    {
        private readonly IPartService partService;
        private readonly ISupplierService supplierService;

        public PartsController(IPartService partService, ISupplierService supplierService)
        {
            this.partService = partService;
            this.supplierService = supplierService;
        }

        [Route("parts/all")]
        public IActionResult All()
        {
            var parts = this.partService.Parts();

            return View(parts);
        }

        [Route("parts/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("parts/add")]
        public IActionResult Add(CreatePartModel model)
        {
            if (!this.supplierService.Exists(model.SupplierName))
            {
                return View(model);
            }

            var supplier = this.supplierService.GetSupplier(model.SupplierName);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.partService.Create(model.Name, model.Price, supplier, model.Quantity);

            return Redirect("/parts/all");
        }

        [Route("parts/edit/{id}")]
        public IActionResult Edit(int id)
        {
            if (!this.partService.Exists(id))
            {
                return Redirect("/parts/all");
            }

            var part = this.partService.GetPartById(id);

            return View(part);
        }

        [HttpPost]
        [Route("parts/edit/{id}")]
        public IActionResult Edit(PartModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.partService.Edit(model.Id, model.Price, model.Quantity);

            return Redirect("/parts/all");
        }

        [Route("parts/delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (!this.partService.Exists(id))
            {
                return Redirect("/parts/all");
            }

            var part = this.partService.GetPartById(id);

            return View(part);
        }

        [HttpPost]
        [Route("parts/delete/{id}")]
        public IActionResult Delete(PartModel model)
        {
            this.partService.Delete(model.Id);

            return Redirect("/parts/all");
        }
    }
}
