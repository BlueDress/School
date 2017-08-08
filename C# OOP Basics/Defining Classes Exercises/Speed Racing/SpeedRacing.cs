using System;
using System.Collections.Generic;

namespace Speed_Racing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            var cars = new Dictionary<string, Car>();
            ProcessCarsData(cars);
            DriveTheCars(cars);
            PrintResult(cars);
        }

        private static void PrintResult(Dictionary<string, Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.DistanceTraveled}");
            }
        }

        private static void DriveTheCars(Dictionary<string, Car> cars)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var model = tokens[1];
                    var distance = double.Parse(tokens[2]);

                    cars[model].Drive(distance);
                }
            }
        }

        private static void ProcessCarsData(Dictionary<string, Car> cars)
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var tokens = Console.ReadLine().Split();
                var model = tokens[0];
                var fuelAmount = double.Parse(tokens[1]);
                var fuelConsumptionForOneKm = double.Parse(tokens[2]);

                var car = new Car(model, fuelAmount, fuelConsumptionForOneKm);

                cars[model] = car;
            }
        }
    }
}
