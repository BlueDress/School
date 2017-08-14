using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            var car = ReadCarData();
            var truck = ReadTruckData();
            DrivingVehicles(car, truck);
            PrintRemainingFuel(car, truck);
        }

        private static void PrintRemainingFuel(Car car, Truck truck)
        {
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }

        private static void DrivingVehicles(Car car, Truck truck)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();
                var command = commands[0];
                var vehicleType = commands[1];
                if (command.Equals("Drive"))
                {
                    var distance = double.Parse(commands[2]);

                    if (vehicleType.Equals("Car"))
                    {
                        car.Drive(distance);
                    }
                    else
                    {
                        truck.Drive(distance);
                    }
                }
                else
                {
                    var fuelAmount = double.Parse(commands[2]);

                    if (vehicleType.Equals("Car"))
                    {
                        car.Refuel(fuelAmount);
                    }
                    else
                    {
                        truck.Refuel(fuelAmount);
                    }
                }
            }
        }

        private static Truck ReadTruckData()
        {
            var data = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(data[1]);
            var fuelConsumption = double.Parse(data[2]);
            return new Truck(fuelQuantity, fuelConsumption);
        }

        private static Car ReadCarData()
        {
            var data = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(data[1]);
            var fuelConsumption = double.Parse(data[2]);
            return new Car(fuelQuantity, fuelConsumption);
        }
    }
}
