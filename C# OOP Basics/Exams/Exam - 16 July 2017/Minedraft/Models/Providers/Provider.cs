using Minedraft.Models.Contracts;
using System;
using System.Text;

namespace Minedraft.Models.Providers
{
    public abstract class Provider : IMiner
    {
        private string id;
        private double energyOutput;

        protected Provider(string id, double energyOutput)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
        }

        public string Id
        {
            get { return this.id; }
            protected set { this.id = value; }
        }

        public double EnergyOutput
        {
            get { return this.energyOutput; }
            protected set
            {
                if (value < 0 || 10000 <= value)
                {
                    throw new Exception("Provider is not registered, because of it's EnergyOutput");
                }

                this.energyOutput = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Provider – {this.id}");
            sb.AppendLine($"Energy Output: {this.energyOutput}");

            return sb.ToString().TrimEnd();
        }
    }
}
