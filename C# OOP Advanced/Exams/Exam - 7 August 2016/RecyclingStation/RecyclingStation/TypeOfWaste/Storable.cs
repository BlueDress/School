namespace RecyclingStation.TypeOfWaste
{
    using Attributes;
    using TypeOfGarbageDisposalStrategy;

    [Storable(typeof(StorableGarbageDisposalStrategy))]
    public class Storable : Waste
    {
        public Storable(string name, double volumePerKg, double weight) : base(name, volumePerKg, weight)
        {
        }
    }
}
