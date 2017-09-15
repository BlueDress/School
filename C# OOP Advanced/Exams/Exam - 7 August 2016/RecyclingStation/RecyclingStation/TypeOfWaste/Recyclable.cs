namespace RecyclingStation.TypeOfWaste
{
    using Attributes;
    using TypeOfGarbageDisposalStrategy;

    [Recyclable(typeof(RecyclableGarbageDisposalStrategy))]
    public class Recyclable : Waste
    {
        public Recyclable(string name, double volumePerKg, double weight) : base(name, volumePerKg, weight)
        {
        }
    }
}
