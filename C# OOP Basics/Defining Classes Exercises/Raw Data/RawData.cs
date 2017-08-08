using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
    public class RawData
    {
        public static void Main()
        {
            var cars = new List<Car>();
            ProcessCarData(cars);
            PrintResult(cars);
        }

        private static void PrintResult(List<Car> cars)
        {
            var command = Console.ReadLine();

            if (command.Equals("fragile"))
            {
                foreach (var car in cars.Where(car => car.Cargo.Type.Equals(command)).Where(car => car.Tires.Any(tire => tire.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(car => car.Cargo.Type.Equals(command)).Where(car => car.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }

        private static void ProcessCarData(List<Car> cars)
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var tokens = Console.ReadLine().Split();
                var model = tokens[0];
                var engineSpeed = int.Parse(tokens[1]);
                var enginePower = int.Parse(tokens[2]);
                var cargoWeight = int.Parse(tokens[3]);
                var cargoType = tokens[4];
                var firstTirePressure = double.Parse(tokens[5]);
                var firstTireAge = int.Parse(tokens[6]);
                var secondTirePressure = double.Parse(tokens[7]);
                var secondTireAge = int.Parse(tokens[8]);
                var thirdTirePressure = double.Parse(tokens[9]);
                var thirdTireAge = int.Parse(tokens[10]);
                var fourthTirePressure = double.Parse(tokens[11]);
                var fourthTireAge = int.Parse(tokens[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var firstTire = new Tire(firstTireAge, firstTirePressure);
                var secondTire = new Tire(secondTireAge, secondTirePressure);
                var thirdTire = new Tire(thirdTireAge, thirdTirePressure);
                var fourthTire = new Tire(fourthTireAge, fourthTirePressure);
                var tires = new Tire[] { firstTire, secondTire, thirdTire, fourthTire };
                var car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }
        }
    }
}
