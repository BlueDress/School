namespace Minedraft.Models.Providers
{
    public class PressureProvider : Provider
    {
        public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
        {
            this.EnergyOutput = 3 * energyOutput / 2;
        }

        public override string ToString()
        {
            return $"Pressure {base.ToString()}";
        }
    }
}
