using System.Collections.Generic;

namespace CarDealer.Services.Models
{
    public class CarWithPartsModel : OrderedCarsModel
    {
        public IEnumerable<PartModel> Parts { get; set; }
    }
}
