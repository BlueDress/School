using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Services
{
    public interface ICustomerService
    {
        IEnumerable<OrderedCustomersModel> OrderedCustomers(OrderType orderType);
    }
}
