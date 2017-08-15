

namespace Avatar.Models.Bender
{
    public class AirBender : Bender
    {
        private double aerialIntegrity;

        public double AerialIntegrity { get { return this.aerialIntegrity; } set { this.aerialIntegrity = value; } }

        public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
        {
            this.AerialIntegrity = aerialIntegrity;
            this.TotalPower = power * aerialIntegrity;
        }

        public override string ToString()
        {
            return base.ToString() + $"Aerial Integrity: {this.AerialIntegrity:f2}";
        }
    }
}
