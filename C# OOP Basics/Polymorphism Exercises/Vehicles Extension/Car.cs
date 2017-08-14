

using System;

namespace Vehicles_Extension
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            var litresComsumed = distance * (this.FuelConsumption + 0.9);
            if (litresComsumed <= this.FuelQuantity)
            {
                this.FuelQuantity -= litresComsumed;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
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
                if (this.FuelQuantity + fuelAmount > this.TankCapacity)
                {
                    Console.WriteLine("Cannot fit fuel in tank");
                }
                else
                {
                    this.FuelQuantity += fuelAmount;
                }
            }
        }
    }
}
