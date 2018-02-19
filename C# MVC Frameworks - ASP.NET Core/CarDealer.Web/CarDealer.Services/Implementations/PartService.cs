using System.Collections.Generic;
using CarDealer.Data;
using CarDealer.Data.Models;
using CarDealer.Services.Models;
using System.Linq;

namespace CarDealer.Services.Implementations
{
    public class PartService : IPartService
    {
        private readonly CarDealerDbContext db;

        public PartService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public void Create(string name, decimal price, Supplier supplier, int? quantity)
        {
            var part = new Part
            {
                Name = name,
                Price = price,
                Supplier = supplier,
                Quantity = quantity == null ? 1 : quantity.Value
            };

            this.db.Parts.Add(part);
            this.db.SaveChanges();
        }

        public void Edit(int id, decimal price, int quantity)
        {
            var partToEdit = this.db.Parts.Find(id);

            partToEdit.Price = price;
            partToEdit.Quantity = quantity;

            this.db.SaveChanges();
        }

        public PartModel GetPartById(int id)
        {
            var part = this.db.Parts.Where(p => p.Id == id).Select(p => new PartModel
            {
                Name = p.Name,
                Price = p.Price,
                SupplierName = p.Supplier.Name,
                Quantity = p.Quantity
            }).First();

            return part;
        }

        public IEnumerable<PartModel> Parts()
        {
            return this.db.Parts.Select(p => new PartModel
            {
                Id = p.Id,
                Name = p.Name,
                SupplierName = p.Supplier.Name,
                Price = p.Price,
                Quantity = p.Quantity
            });
        }

        public bool Exists(int id)
        {
            return this.db.Parts.Any(p => p.Id == id);
        }

        public void Delete(int id)
        {
            var partToDelete = this.db.Parts.Find(id);

            db.Parts.Remove(partToDelete);
            db.SaveChanges();
        }
    }
}
