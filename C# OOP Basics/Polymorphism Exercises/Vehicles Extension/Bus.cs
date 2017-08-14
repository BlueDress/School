using System;

namespace Vehicles_Extension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            var litresComsumed = distance * (this.FuelConsumption + 1.4);
            if (litresComsumed <= this.FuelQuantity)
            {
                this.FuelQuantity -= litresComsumed;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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

        public void DriveEmpty(double distance)
        {
            var litresComsumed = distance * this.FuelConsumption;
            if (litresComsumed <= this.FuelQuantity)
            {
                this.FuelQuantity -= litresComsumed;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
    }
}
