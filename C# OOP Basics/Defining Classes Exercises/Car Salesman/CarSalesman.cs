using System;
using System.Collections.Generic;

namespace Car_Salesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            var engines = new List<Engine>();
            var cars = new List<Car>();
            ReadEngineData(engines);
            ReadCarData(cars, engines);
            PrintReslut(cars);
        }

        private static void PrintReslut(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static void ReadCarData(List<Car> cars, List<Engine> engines)
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var tokens = Console.ReadLine().Split();
                var model = tokens[0];
                var engineModel = tokens[1];
                var engine = engines.Find(eng => eng.Model.Equals(engineModel));

                if (tokens.Length == 2)
                {
                    var car = new Car(model, engine);
                    cars.Add(car);
                }
                else if (tokens.Length == 4)
                {
                    var weight = int.Parse(tokens[2]);
                    var color = tokens[3];
                    var car = new Car(model, engine, weight, color);
                    cars.Add(car);
                }
                else
                {
                    var weight = 0;
                    var color = tokens[2];

                    if (int.TryParse(tokens[2], out weight))
                    {
                        var car = new Car(model, engine, weight);
                        cars.Add(car);
                    }
                    else
                    {
                        var car = new Car(model, engine, color);
                        cars.Add(car);
                    }
                }
            }
        }

        private static void ReadEngineData(List<Engine> engines)
        {
            var numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                var tokens = Console.ReadLine().Split();
                var model = tokens[0];
                var power = tokens[1];

                if (tokens.Length == 2)
                {
                    var engine = new Engine(model, power);
                    engines.Add(engine);
                }
                else if (tokens.Length == 4)
                {
                    var displacement = int.Parse(tokens[2]);
                    var efficiency = tokens[3];
                    var engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
                else
                {
                    var displacement = 0;
                    var efficiency = tokens[2];
                    if (int.TryParse(tokens[2], out displacement))
                    {
                        var engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        var engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }
                }
            }
        }
    }
}
