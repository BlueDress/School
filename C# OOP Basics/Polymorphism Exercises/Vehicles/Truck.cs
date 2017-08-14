

using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double distance)
        {
            var litresComsumed = distance * (this.FuelConsumption + 1.6);
            if (litresComsumed <= this.FuelQuantity)
            {
                Console.WriteLine($"Truck travelled {distance} km");
                this.FuelQuantity -= litresComsumed;
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double fuelAmount)
        {
            this.FuelQuantity += fuelAmount * 0.95;
        }
    }
}
