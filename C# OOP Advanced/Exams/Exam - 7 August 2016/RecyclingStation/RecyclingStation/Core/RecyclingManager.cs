namespace RecyclingStation.Core
{
    using Contracts;
    using System.Collections.Generic;
    using WasteDisposal.Interfaces;

    public class RecyclingManager : IRecyclingStation
    {
        private IGarbageProcessor garbageProcessor;
        private IWasteFactory wasteFactory;

        private double energyBalance;
        private double capitalBalance;

        private Dictionary<string, double[]> managementRequirements;

        public RecyclingManager(IGarbageProcessor garbageProcessor, IWasteFactory wasteFactory)
        {
            this.garbageProcessor = garbageProcessor;
            this.wasteFactory = wasteFactory;
            this.managementRequirements = new Dictionary<string, double[]>();
        }

        public string ChangeManagementRequirement(double minEnergyBalance, double minCapitalBalance, string type)
        {
            if (!this.managementRequirements.ContainsKey(type))
            {
                this.managementRequirements[type] = new double[] { minEnergyBalance, minCapitalBalance };
            }
            else
            {
                this.managementRequirements[type][0] = minEnergyBalance;
                this.managementRequirements[type][1] = minCapitalBalance;
            }

            return "Management requirement changed!";
        }

        public string ProcessGarbage(string name, double weight, double volumePerKg, string type)
        {
            if (!this.managementRequirements.ContainsKey(type) || (this.managementRequirements.ContainsKey(type) && this.energyBalance >= this.managementRequirements[type][0] && this.capitalBalance >= this.managementRequirements[type][1]))
            {
                var waste = this.wasteFactory.GetWaste(name, weight, volumePerKg, type);

                var processData = this.garbageProcessor.ProcessWaste(waste);

                CalculateEnergyAndCapitalBalance(processData);

                return $"{weight:f2} kg of {name} successfully processed!";
            }
            else
            {
                return "Processing Denied!";
            }
        }

        private void CalculateEnergyAndCapitalBalance(IProcessingData processData)
        {
            this.energyBalance += processData.EnergyBalance;
            this.capitalBalance += processData.CapitalBalance;
        }

        public string Status()
        {
            return $"Energy: {this.energyBalance:f2} Capital: {this.capitalBalance:f2}";
        }
    }
}
