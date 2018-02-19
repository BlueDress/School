using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Web.Models.CarsModels
{
    public class CarsWithPartsModel
    {
        public IEnumerable<CarWithPartsModel> CarsWithParts { get; set; }
    }
}
