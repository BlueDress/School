using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Services
{
    public interface ICarService
    {
        IEnumerable<OrderedCarsModel> ByMake(string make);

        IEnumerable<CarWithPartsModel> CarWithParts();

        void Add(string make, string model, double travelledDistance, IEnumerable<int> Parts);
    }
}
