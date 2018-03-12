namespace Minedraft.Models.Harvesters
{
    public class SonicHarvester : Harvester
    {
        private int sonicFactor;

        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) :base(id, oreOutput, energyRequirement)
        {
            this.EnergyRequirement = energyRequirement / sonicFactor;
            this.SonicFactor = sonicFactor;
        }

        public int SonicFactor
        {
            get { return this.sonicFactor; }
            private set { this.sonicFactor = value; }
        }

        public override string ToString()
        {
            return $"Sonic {base.ToString()}";
        }
    }
}
