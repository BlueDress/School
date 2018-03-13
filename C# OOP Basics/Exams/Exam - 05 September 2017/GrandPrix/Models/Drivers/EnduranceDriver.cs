using GrandPrix.Models.Contracts;

namespace GrandPrix.Models.Drivers
{
    public class EnduranceDriver : Driver
    {
        public EnduranceDriver(string name, ICar car) : base(name, car)
        {
            this.FuelConsumptionPerKm = 1.5;
        }
    }
}
