namespace RecyclingStation.TypeOfWaste
{
    using Attributes;
    using TypeOfGarbageDisposalStrategy;

    [Burnable(typeof(BurnableGarbageDisposalStrategy))]
    public class Burnable : Waste
    {
        public Burnable(string name, double volumePerKg, double weight) : base(name, volumePerKg, weight)
        {
        }
    }
}
