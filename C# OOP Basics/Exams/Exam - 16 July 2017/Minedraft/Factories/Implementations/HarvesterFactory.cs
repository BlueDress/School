using Minedraft.Models.Harvesters;

namespace Minedraft.Factories.Implementations
{
    public static class HarvesterFactory
    {
        private const string sonicType = "Sonic";

        public static Harvester CreateHarvester(params string[] arguments)
        {
            var type = arguments[0];
            var id = arguments[1];
            var oreOutput = double.Parse(arguments[2]);
            var energyRequirement = double.Parse(arguments[3]);

            if (type.Equals(sonicType))
            {
                var sonicFactor = int.Parse(arguments[4]);

                var sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);

                return sonicHarvester;
            }
            else
            {
                var hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);

                return hammerHarvester;
            }
        }
    }
}
