using GrandPrix.Factories;
using GrandPrix.Models.Drivers;
using GrandPrix.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandPrix.Services.Implementations
{
    public class RaceTower
    {
        private int currentLap;
        private int lapsLeft;
        private int trackLength;
        private Weather weather;
        private IList<Driver> drivers;
        private IList<Driver> failedDrivers;

        public RaceTower()
        {
            this.weather = Weather.Sunny;
            this.drivers = new List<Driver>();
            this.failedDrivers = new List<Driver>();
        }

        public int LapsLeft
        {
            get => this.lapsLeft;
            private set => this.lapsLeft = value;
        }

        public void ChangeWeather(List<string> commandArgs)
        {
            var weatheType = commandArgs[0];

            this.weather = (Weather)Enum.Parse(typeof(Weather), weatheType);
        }

        public string CompleteLaps(List<string> commandArgs)
        {
            var sb = new StringBuilder();
            var numberOfLaps = int.Parse(commandArgs[0]);

            if (numberOfLaps > this.LapsLeft)
            {
                return $"There is no time! On lap {this.currentLap}.";
            }
            else
            {
                this.LapsLeft -= numberOfLaps;

                for (int i = this.currentLap + 1; i <= this.currentLap + numberOfLaps; i++)
                {
                    foreach (var driver in this.drivers.Where(d => !d.DriverFailed))
                    {
                        driver.TotalTime += 60 / (this.trackLength / driver.GetSpeed());

                        try
                        {
                            driver.Car.FuelAmount -= this.trackLength * driver.FuelConsumptionPerKm;
                        }
                        catch (Exception)
                        {
                            driver.DriverFailed = true;
                            driver.FailureReason = "Out of fuel";
                            this.failedDrivers.Insert(0, driver);
                        }

                        try
                        {
                            driver.Car.Tyre.Degrade();
                        }
                        catch (Exception)
                        {
                            driver.DriverFailed = true;
                            driver.FailureReason = "Blown Tyre";
                            this.failedDrivers.Insert(0, driver);
                        }
                    }

                    var orderedDrivers = this.drivers.Where(d => !d.DriverFailed).OrderByDescending(d => d.TotalTime).ToList();

                    for (int j = 0; j < orderedDrivers.Count - 1; j++)
                    {
                        if (orderedDrivers[j].GetType().Name.Equals("AggressiveDriver") && orderedDrivers[j].Car.Tyre.GetType().Name.Equals("UltrasoftTyre"))
                        {
                            if (orderedDrivers[j].TotalTime - 3 <= orderedDrivers[j + 1].TotalTime)
                            {
                                if (this.weather.Equals(Weather.Foggy))
                                {
                                    orderedDrivers[j].DriverFailed = true;
                                    orderedDrivers[j].FailureReason = "Crashed";
                                    this.failedDrivers.Insert(0, orderedDrivers[j]);
                                }
                                else
                                {
                                    orderedDrivers[j].TotalTime -= 3;
                                    orderedDrivers[j + 1].TotalTime += 3;

                                    sb.AppendLine($"{orderedDrivers[j].Name} has overtaken {orderedDrivers[j + 1].Name} on lap {i}.");

                                    j++;
                                }
                            }
                        }
                        else if (orderedDrivers[j].GetType().Name.Equals("EnduranceDriver") && orderedDrivers[j].Car.Tyre.GetType().Name.Equals("HardTyre"))
                        {
                            if (orderedDrivers[j].TotalTime - 3 <= orderedDrivers[j + 1].TotalTime)
                            {
                                if (this.weather.Equals(Weather.Rainy))
                                {
                                    orderedDrivers[j].DriverFailed = true;
                                    orderedDrivers[j].FailureReason = "Crashed";
                                    this.failedDrivers.Insert(0, orderedDrivers[j]);
                                }
                                else
                                {
                                    orderedDrivers[j].TotalTime -= 3;
                                    orderedDrivers[j + 1].TotalTime += 3;

                                    sb.AppendLine($"{orderedDrivers[j].Name} has overtaken {orderedDrivers[j + 1].Name} on lap {i}.");

                                    j++;
                                }
                            }
                        }
                        else if (orderedDrivers[j].TotalTime - 2 <= orderedDrivers[j + 1].TotalTime)
                        {
                            orderedDrivers[j].TotalTime -= 2;
                            orderedDrivers[j + 1].TotalTime += 2;

                            sb.AppendLine($"{orderedDrivers[j].Name} has overtaken {orderedDrivers[j + 1].Name} on lap {i}.");

                            j++;
                        }
                    }
                }

                this.currentLap += numberOfLaps;

                return sb.ToString().TrimEnd();
            }
        }

        public void DriverBoxes(List<string> commandArgs)
        {
            var reasonToBox = commandArgs[0];
            var driversName = commandArgs[1];

            var driverBoxed = this.drivers.Where(d => d.Name.Equals(driversName)).First();

            if (reasonToBox.Equals("ChangeTyres"))
            {
                var tyre = TyreFactory.GetTyre(commandArgs.Skip(2).ToList());
                driverBoxed.Car.Tyre = tyre;
            }
            else if (reasonToBox.Equals("Refuel"))
            {
                var fuelAmount = double.Parse(commandArgs[2]);
                driverBoxed.Car.FuelAmount += fuelAmount;
            }

            driverBoxed.TotalTime += 20;
        }

        public string GetLeaderboard()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Lap {this.currentLap}/{this.LapsLeft + this.currentLap}");

            var orderedDrivers = this.drivers.Where(d => !d.DriverFailed).OrderBy(d => d.TotalTime).ToList();

            for (int i = 0; i < orderedDrivers.Count; i++)
            {
                sb.AppendLine($"{i + 1} {orderedDrivers[i].Name} {orderedDrivers[i].TotalTime:f3}");
            }

            for (int i = 0; i < this.failedDrivers.Count; i++)
            {
                sb.AppendLine($"{i + 1 + orderedDrivers.Count} {failedDrivers[i].Name} {failedDrivers[i].FailureReason}");
            }

            return sb.ToString().TrimEnd();
        }

        public void RegisterDriver(List<string> commandArgs)
        {
            try
            {
                var type = commandArgs[0];
                var name = commandArgs[1];
                var carHp = int.Parse(commandArgs[2]);
                var carFuelAmount = double.Parse(commandArgs[3]);

                var tyre = TyreFactory.GetTyre(commandArgs.Skip(4).ToList());
                var car = CarFactory.GetCar(carHp, carFuelAmount, tyre);
                var driver = DriverFactory.GetDriver(type, name, car);

                if (tyre != null && car != null && driver != null)
                {
                    this.drivers.Add(driver);
                }
            }
            catch (Exception)
            {

            }
        }

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            this.LapsLeft = lapsNumber;
            this.trackLength = trackLength;
            this.currentLap = 0;
        }

        public Driver GetWinner()
        {
            return this.drivers.Where(d => !d.DriverFailed).OrderBy(d => d.TotalTime).First();
        }
    }
}
