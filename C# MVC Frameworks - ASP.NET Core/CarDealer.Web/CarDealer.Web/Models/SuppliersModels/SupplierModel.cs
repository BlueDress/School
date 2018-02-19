using CarDealer.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Web.Models.SuppliersModels
{
    public class SupplierModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public bool IsImporter { get; set; }
    }
}
