using Minedraft.Models.Contracts;
using System;
using System.Text;

namespace Minedraft.Models.Harvesters
{
    public abstract class Harvester : IMiner
    {
        private string id;
        private double oreOutput;
        private double energyRequirement;

        protected Harvester(string id, double oreOutput, double energyRequirement)
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public string Id
        {
            get { return this.id; }
            protected set { this.id = value; }
        }

        public double OreOutput
        {
            get { return this.oreOutput; }
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("Harvester is not registered, because of it's OreOutput");
                }

                this.oreOutput = value;
            }
        }

        public double EnergyRequirement
        {
            get { return this.energyRequirement; }
            protected set
            {
                if (value < 0 || 20000 < value)
                {
                    throw new Exception("Harvester is not registered, because of it's EnergyRequirement");
                }

                this.energyRequirement = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Harvester – {this.Id}");
            sb.AppendLine($"Ore Output: {this.oreOutput}");
            sb.AppendLine($"Energy Requirement: {this.energyRequirement}");

            return sb.ToString().TrimEnd();
        }
    }
}
