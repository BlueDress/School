using System.Collections.Generic;
using CarDealer.Services.Models;
using CarDealer.Data;
using System.Linq;
using System;
using CarDealer.Data.Models;

namespace CarDealer.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public Customer ById(int id)
        {
            var customer = this.db.Customers.Find(id);

            return customer;
        }

        public void Create(string name, DateTime birthDate, bool isYoungDriver)
        {
            var customer = new Customer
            {
                Name = name,
                BirthDate = birthDate,
                IsYoungDriver = isYoungDriver
            };

            this.db.Customers.Add(customer);
            this.db.SaveChanges();
        }

        public void Edit(int id, string name, DateTime birthDate)
        {
            var customerToEdit = this.db.Customers.Find(id);

            customerToEdit.Name = name;
            customerToEdit.BirthDate = birthDate;

            this.db.SaveChanges();
        }

        public CustomerSalesModel GetCustomerSales(int id)
        {
            var customer = this.db.Customers.Find(id);

            var customerWithSales = new CustomerSalesModel
            {
                Name = customer.Name,
                BoughtCarsCount = customer.Purchases.Count,
                TotalMoneySpent = customer.IsYoungDriver ? customer.Purchases.Sum(s => s.Car.Parts.Sum(pc => (pc.Part.Price - (((s.Discount + 5) / 100) * pc.Part.Price)))) : customer.Purchases.Sum(s => s.Car.Parts.Sum(pc => (pc.Part.Price - ((s.Discount / 100) * pc.Part.Price))))
            };

            return customerWithSales;
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
                Id = c.Id,
                Name = c.Name,
                BirthDate = c.BirthDate,
                IsYoungDriver = c.IsYoungDriver
            }).ToList();
        }

        public bool CustomerExists(int id)
        {
            return this.db.Customers.Any(c => c.Id == id);
        }
    }
}
