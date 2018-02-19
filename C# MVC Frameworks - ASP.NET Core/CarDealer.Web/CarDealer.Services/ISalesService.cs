using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Services
{
    public interface ISalesService
    {
        IEnumerable<SaleModel> GetAllSales();

        SaleModel GetSale(int id);

        IEnumerable<SaleModel> GetAllSalesWithDiscount();

        IEnumerable<SaleModel> GetAllSalesWithSpecificDiscount(int discount);

        AddSaleModel GetSaleModel();

        ViewSaleModel GetViewSaleModel(int selectedCar, int selectedCustomer, int discount);

        void AddSale(int carId, int customerId, string discount);
    }
}
