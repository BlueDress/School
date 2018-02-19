using CarDealer.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Web.Models.SalesModels
{
    public class AddSale
    {
        public int Id { get; set; }

        [Range(0, 100)]
        public int Discount { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int SelectedCar { get; set; }
        public IEnumerable<SelectListItem> Cars { get; set; }

        public int SelectedCustomer { get; set; }
        public IEnumerable<SelectListItem> Customers { get; set; }
    }
}
