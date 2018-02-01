using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Web.Models.CustomersModel
{
    public class AllCustomersModel
    {
        public IEnumerable<OrderedCustomersModel> Customers { get; set; }

        public OrderType OrderType { get; set; }
    }
}
