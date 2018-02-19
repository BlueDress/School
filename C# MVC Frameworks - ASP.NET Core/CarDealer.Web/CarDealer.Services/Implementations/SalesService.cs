using System.Collections.Generic;
using CarDealer.Services.Models;
using CarDealer.Data;
using System.Linq;
using CarDealer.Data.Models;

namespace CarDealer.Services.Implementations
{
    public class SalesService : ISalesService
    {
        private readonly CarDealerDbContext db;

        public SalesService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public void AddSale(int carId, int customerId, string discount)
        {
            var discountAsInt = int.Parse(string.Join("", discount.Take(discount.IndexOf('%'))));

            var sale = new Sale
            {
                CarId = carId,
                CustomerId = customerId,
                Discount = discountAsInt
            };

            this.db.Sales.Add(sale);
            this.db.SaveChanges();
        }

        public IEnumerable<SaleModel> GetAllSales()
        {
            return this.db.Sales.Select(s => new SaleModel
            {
                Customer = new OrderedCustomersModel
                {
                    Name = s.Customer.Name
                },
                Discount = s.Discount,
                FullPrice = s.Car.Parts.Sum(pc => pc.Part.Price),
                PriceWithDiscount = s.Customer.IsYoungDriver ? s.Car.Parts.Sum(pc => pc.Part.Price) - (s.Car.Parts.Sum(pc => pc.Part.Price) * (s.Discount + 5/ 100)) : s.Car.Parts.Sum(pc => pc.Part.Price) - (s.Car.Parts.Sum(pc => pc.Part.Price) * (s.Discount / 100)),
                CarWithParts = new CarWithPartsModel
                {
                    Make = s.Car.Make,
                    Model = s.Car.Model,
                    TravelledDistance = s.Car.TraveledDistance
                }
            });
        }

        public IEnumerable<SaleModel> GetAllSalesWithDiscount()
        {
            return this.db.Sales.Where(s => s.Discount > 0 || s.Customer.IsYoungDriver).Select(s => new SaleModel
            {
                Customer = new OrderedCustomersModel
                {
                    Name = s.Customer.Name
                },
                Discount = s.Customer.IsYoungDriver ? s.Discount + 5 : s.Discount,
                FullPrice = s.Car.Parts.Sum(pc => pc.Part.Price),
                PriceWithDiscount = s.Customer.IsYoungDriver ? s.Car.Parts.Sum(pc => pc.Part.Price) - (s.Car.Parts.Sum(pc => pc.Part.Price) * ((s.Discount + 5)/ 100)) : s.Car.Parts.Sum(pc => pc.Part.Price) - (s.Car.Parts.Sum(pc => pc.Part.Price) * (s.Discount / 100)),
                CarWithParts = new CarWithPartsModel
                {
                    Make = s.Car.Make,
                    Model = s.Car.Model,
                    TravelledDistance = s.Car.TraveledDistance
                }
            });
        }

        public IEnumerable<SaleModel> GetAllSalesWithSpecificDiscount(int discount)
        {
            return this.db.Sales.Where(s => (s.Customer.IsYoungDriver ? s.Discount + 5 : s.Discount) == discount).Select(s => new SaleModel
            {
                Customer = new OrderedCustomersModel
                {
                    Name = s.Customer.Name
                },
                Discount = s.Customer.IsYoungDriver ? s.Discount + 5 : s.Discount,
                FullPrice = s.Car.Parts.Sum(pc => pc.Part.Price),
                PriceWithDiscount = s.Customer.IsYoungDriver ? s.Car.Parts.Sum(pc => pc.Part.Price) - (s.Car.Parts.Sum(pc => pc.Part.Price) * ((s.Discount + 5) / 100)) : s.Car.Parts.Sum(pc => pc.Part.Price) - (s.Car.Parts.Sum(pc => pc.Part.Price) * (s.Discount / 100)),
                CarWithParts = new CarWithPartsModel
                {
                    Make = s.Car.Make,
                    Model = s.Car.Model,
                    TravelledDistance = s.Car.TraveledDistance
                }
            });
        }

        public ViewSaleModel GetViewSaleModel(int selectedCar, int selectedCustomer, int discount)
        {
            var customer = this.db.Customers.Find(selectedCustomer);
            var discountAsString = this.db.Customers.Find(selectedCustomer).IsYoungDriver ? $"{discount}% (+5%)" : $"{discount}%";
            var finalDiscount = customer.IsYoungDriver ? discount + 5 : discount;

            return this.db.Cars.Where(c => c.Id == selectedCar).Select(c => new ViewSaleModel
            {
                CustomerId = selectedCustomer,
                CustomerName = customer.Name,
                CarId = selectedCar,
                CarMakeModel = $"{c.Make} {c.Model}",
                Discount = discountAsString,
                Price = c.Parts.Sum(p => p.Part.Price),
                FinalPrice = c.Parts.Sum(p => p.Part.Price) - (c.Parts.Sum(p => p.Part.Price) * ((decimal)finalDiscount / 100))
            }).First();
        }

        public SaleModel GetSale(int id)
        {
            var sale = this.db.Sales.Find(id);

            return new SaleModel
            {
                Customer = new OrderedCustomersModel
                {
                    Name = sale.Customer.Name
                },
                Discount = sale.Customer.IsYoungDriver ? sale.Discount + 5 : sale.Discount,
                FullPrice = sale.Car.Parts.Sum(pc => pc.Part.Price),
                PriceWithDiscount = sale.Customer.IsYoungDriver ? sale.Car.Parts.Sum(pc => pc.Part.Price) - (sale.Car.Parts.Sum(pc => pc.Part.Price) * ((sale.Discount + 5) / 100)) : sale.Car.Parts.Sum(pc => pc.Part.Price) - (sale.Car.Parts.Sum(pc => pc.Part.Price) * (sale.Discount / 100)),
                CarWithParts = new CarWithPartsModel
                {
                    Make = sale.Car.Make,
                    Model = sale.Car.Model,
                    TravelledDistance = sale.Car.TraveledDistance
                }
            };
        }

        public AddSaleModel GetSaleModel()
        {
            var customers = this.db.Customers.ToList();
            var cars = this.db.Cars.ToList();

            return new AddSaleModel
            {
                Cars = cars,
                Customers = customers
            };
        }
    }
}
