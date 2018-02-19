using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Web.Models.CarsModels
{
    public class CarsByMakeModel
    {
        public string Make { get; set; }

        public IEnumerable<OrderedCarsModel> Cars { get; set; }
    }
}
