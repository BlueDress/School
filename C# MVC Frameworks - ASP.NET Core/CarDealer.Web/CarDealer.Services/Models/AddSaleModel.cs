using CarDealer.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Services.Models
{
    public class AddSaleModel
    {
        public IEnumerable<Customer> Customers { get; set; }

        public IEnumerable<Car> Cars { get; set; }

        [Range(0, 100)]
        public int Discount { get; set; }
    }
}
