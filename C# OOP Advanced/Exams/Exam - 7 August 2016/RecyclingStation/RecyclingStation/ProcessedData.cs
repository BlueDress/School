namespace RecyclingStation
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class ProcessedData : IProcessingData
    {
        public ProcessedData(double capitalBalance, double energyBalance)
        {
            this.CapitalBalance = capitalBalance;
            this.EnergyBalance = energyBalance;
        }

        public double CapitalBalance { get; private set; }

        public double EnergyBalance { get; private set; }
    }
}
