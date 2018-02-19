using System.Collections.Generic;
using CarDealer.Services.Models;
using CarDealer.Data;
using System.Linq;
using CarDealer.Data.Models;

namespace CarDealer.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly CarDealerDbContext db;

        public CarService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public void Add(string make, string model, double travelledDistance, IEnumerable<int> Parts)
        {
            var carParts = new List<PartCar>();

            foreach (var part in Parts)
            {
                carParts.Add(new PartCar { PartId = part });
            }

            var carToAdd = new Car
            {
                Make = make,
                Model = model,
                TraveledDistance = travelledDistance,
                Parts = carParts
            };

            this.db.Cars.Add(carToAdd);
            this.db.SaveChanges();
        }

        public IEnumerable<OrderedCarsModel> ByMake(string make)
        {
            return this.db.Cars.Where(c => c.Make.Equals(make)).OrderBy(c => c.Model).ThenByDescending(c => c.TraveledDistance).Select(c => new OrderedCarsModel
            {
                Make = c.Make,
                Model = c.Model,
                TravelledDistance = c.TraveledDistance
            });
        }

        public IEnumerable<CarWithPartsModel> CarWithParts()
        {
            return this.db.Cars.Select(c => new CarWithPartsModel
            {
                Make = c.Make,
                Model = c.Model,
                TravelledDistance = c.TraveledDistance,
                Parts = c.Parts.Select(p => new PartModel
                {
                    Id = p.PartId,
                    Name = p.Part.Name,
                    Price = p.Part.Price
                })
            }).ToList();
        }
    }
}
