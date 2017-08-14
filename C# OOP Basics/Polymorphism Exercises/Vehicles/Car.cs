

using System;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double distance)
        {
            var litresComsumed = distance * (this.FuelConsumption + 0.9);
            if (litresComsumed <= this.FuelQuantity)
            {
                Console.WriteLine($"Car travelled {distance} km");
                this.FuelQuantity -= litresComsumed;
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double fuelAmount)
        {
            this.FuelQuantity += fuelAmount;
        }
    }
}
