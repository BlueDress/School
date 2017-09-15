namespace RecyclingStation.TypeOfGarbageDisposalStrategy
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class StorableGarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            var capitalBalance = -((garbage.Weight * garbage.VolumePerKg) * 0.65);
            var energyBalance = -((garbage.Weight * garbage.VolumePerKg) * 0.13);

            return new ProcessedData(capitalBalance, energyBalance);
        }
    }
}
