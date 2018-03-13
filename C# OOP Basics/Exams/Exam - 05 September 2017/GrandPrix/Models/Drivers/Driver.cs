using GrandPrix.Models.Contracts;

namespace GrandPrix.Models.Drivers
{
    public abstract class Driver
    {
        private string name;
        private double totalTime;
        private ICar car;
        private double fuelConsumptionPerKm;
        private double speed;
        private bool driverFailed;
        private string failureReason;

        protected Driver(string name, ICar car)
        {
            this.Name = name;
            this.Car = car;
            this.driverFailed = false;
        }

        public string Name
        {
            get => this.name;
            protected set => this.name = value;
        }

        public double TotalTime
        {
            get => this.totalTime;
            set => this.totalTime = value;
        }

        public ICar Car
        {
            get => this.car;
            set => this.car = value;
        }

        public double FuelConsumptionPerKm
        {
            get => this.fuelConsumptionPerKm;
            protected set => this.fuelConsumptionPerKm = value;
        }

        public bool DriverFailed
        {
            get => this.driverFailed;
            set => this.driverFailed = value;
        }

        public string FailureReason
        {
            get => this.failureReason;
            set => this.failureReason = value;
        }

        public virtual double GetSpeed()
        {
            return (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
        }
    }
}
