using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainlands
{
    public class Startup
    {
        public static void Main()
        {
            var trains = new List<Train>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("It's Training Men!"))
                {
                    break;
                }

                var args = input.Split();
                var trainName = args[0];

                if (args.Length == 5)
                {
                    var wagonName = args[2];
                    var wagonPower = int.Parse(args[4]);

                    var wagon = new Wagon(wagonName, wagonPower);

                    if (trains.Any(t => t.Name.Equals(trainName)))
                    {
                        var currentTrain = trains.First(t => t.Name.Equals(trainName));
                        currentTrain.Wagons.Add(wagon);
                    }
                    else
                    {
                        var train = new Train(trainName);
                        train.Wagons.Add(wagon);
                        trains.Add(train);
                    }
                }
                else
                {
                    var trainToCutOrCopy = trains.First(t => t.Name.Equals(args[2]));

                    if (args[1].Equals("->"))
                    {
                        if (trains.Any(t => t.Name.Equals(trainName)))
                        {
                            var currentTrain = trains.First(t => t.Name.Equals(trainName));
                            currentTrain.Wagons.AddRange(trainToCutOrCopy.Wagons);
                        }
                        else
                        {
                            var train = new Train(trainName);
                            train.Wagons.AddRange(trainToCutOrCopy.Wagons);
                            trains.Add(train);
                        }

                        trains.Remove(trainToCutOrCopy);
                    }
                    else
                    {
                        if (trains.Any(t => t.Name.Equals(trainName)))
                        {
                            var currentTrain = trains.First(t => t.Name.Equals(trainName));
                            currentTrain.Wagons.Clear();
                            currentTrain.Wagons.AddRange(trainToCutOrCopy.Wagons);
                        }
                        else
                        {
                            var train = new Train(trainName);
                            train.Wagons.AddRange(trainToCutOrCopy.Wagons);
                            trains.Add(train);
                        }
                    }
                }
            }

            foreach (var train in trains.OrderByDescending(t => t.Wagons.Sum(w => w.Power)).ThenBy(t => t.Wagons.Count))
            {
                Console.WriteLine($"Train: {train.Name}");

                foreach (var wagon in train.Wagons.OrderByDescending(w => w.Power))
                {
                    Console.WriteLine($"###{wagon.Name} - {wagon.Power}");
                }
            }
        }
    }
}
