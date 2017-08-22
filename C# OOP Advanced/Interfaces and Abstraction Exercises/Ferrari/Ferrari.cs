namespace Ferrari
{
    public class Ferrari : ICar
    {
        public string DriverName
        {
            get;
        }

        public string Model
        {
            get;
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }

        public Ferrari(string model, string driverName)
        {
            this.Model = model;
            this.DriverName = driverName;
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.DriverName}";
        }
    }
}
