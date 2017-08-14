
namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelComsumption;

        public double FuelQuantity { get { return this.fuelQuantity; } set { this.fuelQuantity = value; } }
        public double FuelConsumption { get { return this.fuelComsumption; } set { this.fuelComsumption = value; } }

        public abstract void Drive(double distance);
        public abstract void Refuel(double fuelAmount);

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
    }
}
