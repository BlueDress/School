using System.Collections.Generic;
using CarDealer.Services.Models;
using CarDealer.Data;
using System.Linq;
using System;

namespace CarDealer.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<OrderedCustomersModel> OrderedCustomers(OrderType orderType)
        {
            var customersQuerry = this.db.Customers.AsQueryable();

            switch (orderType)
            {
                case OrderType.Ascending:
                    customersQuerry = customersQuerry.OrderBy(c => c.BirthDate).ThenBy(c => !c.IsYoungDriver);
                    break;

                case OrderType.Descending:
                    customersQuerry = customersQuerry.OrderByDescending(c => c.BirthDate).ThenBy(c => !c.IsYoungDriver);
                    break;

                default:
                    throw new InvalidOperationException("Invalid querry type");
            }

            return customersQuerry.Select(c => new OrderedCustomersModel
            {
                Name = c.Name,
                BirthDate = c.BirthDate,
                IsYoungDriver = c.IsYoungDriver
            }).ToList();
        }
    }
}
