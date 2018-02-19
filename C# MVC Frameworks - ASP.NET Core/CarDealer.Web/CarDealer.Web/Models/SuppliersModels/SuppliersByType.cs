using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Web.Models.SuppliersModels
{
    public class SuppliersByType
    {
        public IEnumerable<SuppliersModel> Suppliers { get; set; }

        public SupplierType SupplierType { get; set; }
    }
}
