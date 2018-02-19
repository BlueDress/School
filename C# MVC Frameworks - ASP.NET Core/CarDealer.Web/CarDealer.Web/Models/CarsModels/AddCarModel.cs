using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Web.Models.CarsModels
{
    public class AddCarModel
    {
        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Range(0, double.MaxValue)]
        public double TravelledDistance { get; set; }

        public IEnumerable<int> SelectedParts { get; set; }

        public IEnumerable<SelectListItem> Parts { get; set; }
    }
}
