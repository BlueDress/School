

namespace Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionForOneKm;
        private double distanceTraveled;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }
        public double FuelConsumptionForOneKm
        {
            get
            {
                return this.fuelConsumptionForOneKm;
            }
            set
            {
                this.fuelConsumptionForOneKm = value;
            }
        }
        public double DistanceTraveled
        {
            get
            {
                return this.distanceTraveled;
            }
            set
            {
                this.distanceTraveled = value;
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumptionForOneKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionForOneKm = fuelConsumptionForOneKm;
            this.distanceTraveled = 0;
        }
        public void Drive(double distance)
        {
            if (distance * this.fuelConsumptionForOneKm <= this.fuelAmount)
            {
                this.distanceTraveled += distance;
                this.fuelAmount -= distance * this.fuelConsumptionForOneKm;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
