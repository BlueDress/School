

namespace Avatar.Models.Bender
{
    public class EarthBender : Bender
    {
        private double groundSaturation;

        public double GroundSaturation { get { return this.groundSaturation; } set { this.groundSaturation = value; } }

        public EarthBender(string name, int power, double groundSaturation) : base(name, power)
        {
            this.GroundSaturation = groundSaturation;
            this.TotalPower = power * groundSaturation;
        }

        public override string ToString()
        {
            return base.ToString() + $"Ground Saturation: {this.GroundSaturation:f2}";
        }
    }
}
