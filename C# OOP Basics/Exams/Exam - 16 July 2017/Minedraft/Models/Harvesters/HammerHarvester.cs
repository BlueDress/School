namespace Minedraft.Models.Harvesters
{
    public class HammerHarvester : Harvester
    {
        public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
        {
            this.OreOutput = 3 * oreOutput;
            this.EnergyRequirement = 2 * energyRequirement;
        }

        public override string ToString()
        {
            return $"Hammer {base.ToString()}";
        }
    }
}
