namespace RecyclingStation.TypeOfWaste
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public abstract class Waste : IWaste
    {
        public Waste(string name, double weight, double volumePerKg)
        {
            this.Name = name;
            this.VolumePerKg = volumePerKg;
            this.Weight = weight;
        }

        public string Name { get; }

        public double VolumePerKg { get; }

        public double Weight { get; }
    }
}
