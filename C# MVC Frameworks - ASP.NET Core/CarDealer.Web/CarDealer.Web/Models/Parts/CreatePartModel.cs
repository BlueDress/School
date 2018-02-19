using System.ComponentModel.DataAnnotations;

namespace CarDealer.Web.Models.Parts
{
    public class CreatePartModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public int? Quantity { get; set; }

        [Required]
        [MaxLength(50)]
        public string SupplierName { get; set; }
    }
}
