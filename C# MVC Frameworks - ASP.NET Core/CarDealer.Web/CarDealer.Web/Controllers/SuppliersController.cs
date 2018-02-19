using CarDealer.Services;
using CarDealer.Services.Models;
using CarDealer.Web.Models.SuppliersModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace CarDealer.Web.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISupplierService supplierService;
        private readonly ILogService logService;

        public SuppliersController(ISupplierService supplierService, ILogService logService)
        {
            this.supplierService = supplierService;
            this.logService = logService;
        }

        [Route("suppliers/{supplierType}")]
        public IActionResult ByType(string supplierType)
        {
            var type = supplierType.ToLower().Equals("local") ? SupplierType.Local : SupplierType.Importers;

            var suppliers = this.supplierService.ByType(type);

            return View(new SuppliersByType
            {
                Suppliers = suppliers,
                SupplierType = type
            });
        }

        [Authorize]
        [Route("suppliers/all")]
        public IActionResult All()
        {
            var suppliers = this.supplierService.GetAllSuppliers();

            return View(suppliers.Select(s => new SupplierModel
            {
                Id = s.Id,
                Name = s.Name,
                IsImporter = s.IsImporter
            }));
        }

        [Authorize]
        [Route("suppliers/add")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [Route("suppliers/add")]
        public IActionResult Add(SupplierModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.supplierService.Add(model.Name, model.IsImporter);
            this.logService.Add(User.FindFirst(ClaimTypes.Name).Value, "Add", "Suppliers", DateTime.Now);

            return Redirect("/suppliers/all");
        }

        [Authorize]
        [Route("suppliers/edit/{id}")]
        public IActionResult Edit(int id)
        {
            if (!this.supplierService.Exists(id))
            {
                return Redirect("/suppliers/all");
            }
            
            var supplier = this.supplierService.GetSupplier(id);

            return View(new SupplierModel
            {
                Id = supplier.Id,
                Name = supplier.Name,
                IsImporter = supplier.IsImporter
            });
        }

        [Authorize]
        [HttpPost]
        [Route("suppliers/edit/{id}")]
        public IActionResult Edit(SupplierModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.supplierService.Edit(model.Id, model.Name, model.IsImporter);
            this.logService.Add(User.FindFirst(ClaimTypes.Name).Value, "Edit", "Suppliers", DateTime.Now);

            return Redirect("/suppliers/all");
        }

        [Authorize]
        [Route("suppliers/delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (!this.supplierService.Exists(id))
            {
                return Redirect("/suppliers/all");
            }

            var supplier = this.supplierService.GetSupplier(id);

            return View(new SupplierModel
            {
                Id = supplier.Id,
                Name = supplier.Name,
                IsImporter = supplier.IsImporter
            });
        }

        [Authorize]
        [HttpPost]
        [Route("suppliers/delete/{id}")]
        public IActionResult Delete(SupplierModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.supplierService.Delete(model.Id, model.Name, model.IsImporter);
            this.logService.Add(User.FindFirst(ClaimTypes.Name).Value, "Delete", "Suppliers", DateTime.Now);

            return Redirect("/suppliers/all");
        }
    }
}
