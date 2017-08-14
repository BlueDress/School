using System;

namespace Vehicles_Extension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            var litresComsumed = distance * (this.FuelConsumption + 1.6);
            if (litresComsumed <= this.FuelQuantity)
            {
                this.FuelQuantity -= litresComsumed;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                this.FuelQuantity += fuelAmount * 0.95;
            }
        }
    }
}
