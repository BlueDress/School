using GrandPrix.Models.Contracts;

namespace GrandPrix.Models.Drivers
{
    public class AggressiveDriver : Driver
    {
        public AggressiveDriver(string name, ICar car) : base(name, car)
        {
            this.FuelConsumptionPerKm = 2.7;
        }

        public override double GetSpeed()
        {
            return base.GetSpeed() * 1.3;
        }
    }
}
