using CarDealer.Data.Models;
using CarDealer.Services.Models;
using System;
using System.Collections.Generic;

namespace CarDealer.Services
{
    public interface ICustomerService
    {
        IEnumerable<OrderedCustomersModel> OrderedCustomers(OrderType orderType);

        CustomerSalesModel GetCustomerSales(int id);

        void Create(string name, DateTime birthDate, bool isYoungDriver);

        void Edit(int id, string name, DateTime birthDate);

        Customer ById(int id);

        bool CustomerExists(int id);
    }
}
