using CarDealer.Data;
using CarDealer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using CarDealer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Services.Implementations
{
    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public void Add(string name, bool isImporter)
        {
            var supplier = new Supplier
            {
                Name = name,
                IsImporter = isImporter
            };

            this.db.Suppliers.Add(supplier);
            this.db.SaveChanges();
        }

        public IEnumerable<SuppliersModel> ByType(SupplierType supplierType)
        {
            var suppliersQuerry = this.db.Suppliers.AsQueryable();

            switch (supplierType)
            {
                case SupplierType.Local:
                    suppliersQuerry = suppliersQuerry.Where(s => !s.IsImporter);
                    break;

                case SupplierType.Importers:
                    suppliersQuerry = suppliersQuerry.Where(s => s.IsImporter);
                    break;

                default:
                    throw new InvalidOperationException("Invalid querry type");
            }

            return suppliersQuerry.Select(s => new SuppliersModel
            {
                Id = s.Id,
                Name = s.Name,
                NumberOfParts = s.Parts.Count
            }).ToList();
        }

        public void Delete(int id, string name, bool isImporter)
        {
            var supplier = this.db.Suppliers.Include(s => s.Parts).First(s => s.Id == id);

            this.db.Parts.RemoveRange(supplier.Parts);
            this.db.Suppliers.Remove(supplier);
            this.db.SaveChanges();
        }

        public void Edit(int id, string name, bool isImporter)
        {
            var supplier = this.db.Suppliers.Find(id);

            supplier.Name = name;
            supplier.IsImporter = isImporter;

            this.db.SaveChanges();
        }

        public bool Exists(string name)
        {
            return this.db.Suppliers.Any(s => s.Name.Equals(name));
        }

        public bool Exists(int id)
        {
            return this.db.Suppliers.Any(s => s.Id == id);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return this.db.Suppliers;
        }

        public Supplier GetSupplier(string name)
        {
            return this.db.Suppliers.First(s => s.Name.Equals(name));
        }

        public Supplier GetSupplier(int id)
        {
            return this.db.Suppliers.First(s => s.Id == (id));
        }
    }
}
