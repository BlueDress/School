

using System;

namespace Vehicles_Extension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelComsumption;
        private double tankCapacity;

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelQuantity = value; } }
        public double FuelConsumption { get { return this.fuelComsumption; } set { this.fuelComsumption = value; } }
        public double TankCapacity { get { return this.tankCapacity; } set { this.tankCapacity = value; } }

        public abstract void Drive(double distance);
        public abstract void Refuel(double fuelAmount);

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }
    }
}
