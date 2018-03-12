using System.Collections.Generic;
using Minedraft.Services.Contracts;
using Minedraft.Models.Contracts;
using Minedraft.Models.Enums;
using Minedraft.Factories.Implementations;
using System;
using System.Linq;
using System.Text;
using Minedraft.Models.Harvesters;
using Minedraft.Models.Providers;

namespace Minedraft.Services.Implementations
{
    public class DraftManager : IDraftManager
    {
        private double energyStored;
        private double oreMined;

        private OperatingMode operatingMode;

        private IList<Harvester> harvesters;
        private IList<Provider> providers;
        private IDictionary<string, IMiner> miningMachines;

        public DraftManager()
        {
            this.operatingMode = OperatingMode.Full;
            this.harvesters = new List<Harvester>();
            this.providers = new List<Provider>();
            this.miningMachines = new Dictionary<string, IMiner>();
        }

        public string RegisterHarvester(List<string> arguments)
        {
            try
            {
                var harvester = HarvesterFactory.CreateHarvester(arguments.ToArray());
                var harvesterType = arguments[0];
                var harvesterId = arguments[1];

                this.harvesters.Add(harvester);
                this.miningMachines[harvesterId] = harvester;

                return $"Successfully registered {harvesterType} Harvester – {harvesterId}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string RegisterProvider(List<string> arguments)
        {
            try
            {
                var provider = ProviderFactory.CreateProvider(arguments);
                var providerType = arguments[0];
                var providerId = arguments[1];

                this.providers.Add(provider);
                this.miningMachines[providerId] = provider;

                return $"Successfully registered {providerType} Provider – {providerId}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Check(List<string> arguments)
        {
            var id = arguments[0];

            if (!this.miningMachines.ContainsKey(id))
            {
                return $"No element found with id – {id}";
            }
            else
            {
                var machineToCheck = this.miningMachines.First(m => m.Key.Equals(id)).Value;

                return machineToCheck.ToString();
            }
        }

        public string Mode(List<string> arguments)
        {
            var mode = arguments[0];

            this.operatingMode = (OperatingMode)Enum.Parse(typeof(OperatingMode), mode);

            return $"Successfully changed working mode to {mode} Mode";
        }

        public string Day()
        {
            var energyProvided = this.providers.Sum(p => p.EnergyOutput);
            this.energyStored += energyProvided;

            var energyRequired = this.harvesters.Sum(h => h.EnergyRequirement);
            var oreMined = this.harvesters.Sum(h => h.OreOutput);

            if (this.operatingMode.Equals(OperatingMode.Half))
            {
                energyRequired *= 0.6;
                oreMined *= 0.5;
            }
            else if (this.operatingMode.Equals(OperatingMode.Energy))
            {
                energyRequired = 0;
                oreMined = 0;
            }

            if (this.energyStored >= energyRequired)
            {
                this.energyStored -= energyRequired;
                this.oreMined += oreMined;
            }
            else
            {
                oreMined = 0;
            }

            var sb = new StringBuilder();
            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: {energyProvided}");
            sb.AppendLine($"Plumbus Ore Mined: {oreMined}");

            return sb.ToString().TrimEnd();
        }

        public string ShutDown()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"System Shutdown");
            sb.AppendLine($"Total Energy Stored: {this.energyStored}");
            sb.AppendLine($"Total Mined Plumbus Ore: {this.oreMined}");

            return sb.ToString().TrimEnd();
        }
    }
}
