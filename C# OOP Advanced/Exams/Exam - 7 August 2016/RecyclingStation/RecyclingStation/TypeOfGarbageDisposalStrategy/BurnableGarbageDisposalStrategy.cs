namespace RecyclingStation.TypeOfGarbageDisposalStrategy
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class BurnableGarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            var capitalBalance = 0;
            var energyBalance = (garbage.Weight * garbage.VolumePerKg) * 0.8;

            return new ProcessedData(capitalBalance, energyBalance);
        }
    }
}
