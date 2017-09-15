namespace RecyclingStation.TypeOfGarbageDisposalStrategy
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class RecyclableGarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            var capitalBalance = garbage.Weight * 400;
            var energyBalance = -((garbage.Weight * garbage.VolumePerKg) * 0.5);

            return new ProcessedData(capitalBalance, energyBalance);
        }
    }
}
