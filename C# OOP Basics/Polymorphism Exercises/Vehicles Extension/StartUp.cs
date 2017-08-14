using System;

namespace Vehicles_Extension
{
    public class StartUp
    {
        public static void Main()
        {
            var car = ReadCarData();
            var truck = ReadTruckData();
            var bus = ReadBusData();
            DrivingVehicles(car, truck, bus);
            PrintRemainingFuel(car, truck, bus);
        }

        private static Bus ReadBusData()
        {
            var data = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(data[1]);
            var fuelConsumption = double.Parse(data[2]);
            var tankCapacity = double.Parse(data[3]);
            try
            {
                return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return null;
        }

        private static void PrintRemainingFuel(Car car, Truck truck, Bus bus)
        {
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static void DrivingVehicles(Car car, Truck truck, Bus bus)
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
                    else if (vehicleType.Equals("Truck"))
                    {
                        truck.Drive(distance);
                    }
                    else
                    {
                        bus.Drive(distance);
                    }
                }
                else if (command.Equals("Refuel"))
                {
                    var fuelAmount = double.Parse(commands[2]);

                    if (vehicleType.Equals("Car"))
                    {
                        car.Refuel(fuelAmount);
                    }
                    else if (vehicleType.Equals("Truck"))
                    {
                        truck.Refuel(fuelAmount);
                    }
                    else
                    {
                        bus.Refuel(fuelAmount);
                    }
                }
                else
                {
                    var distance = double.Parse(commands[2]);
                    bus.DriveEmpty(distance);
                }
            }
        }

        private static Truck ReadTruckData()
        {
            var data = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(data[1]);
            var fuelConsumption = double.Parse(data[2]);
            var tankCapacity = double.Parse(data[3]);
            try
            {
                return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return null;
        }

        private static Car ReadCarData()
        {
            var data = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(data[1]);
            var fuelConsumption = double.Parse(data[2]);
            var tankCapacity = double.Parse(data[3]);
            try
            {
                return new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
