using CarDealer.Data.Models;
using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Services
{
    public interface ISupplierService
    {
        IEnumerable<SuppliersModel> ByType(SupplierType supplierType);

        bool Exists(string name);

        bool Exists(int id);

        Supplier GetSupplier(string name);

        Supplier GetSupplier(int id);

        IEnumerable<Supplier> GetAllSuppliers();

        void Add(string name, bool isImporter);

        void Edit(int id, string name, bool isImporter);

        void Delete(int id, string name, bool isImporter);
    }
}
