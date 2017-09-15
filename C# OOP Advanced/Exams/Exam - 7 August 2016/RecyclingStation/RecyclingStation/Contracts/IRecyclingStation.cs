namespace RecyclingStation.Contracts
{
    public interface IRecyclingStation
    {
        string ProcessGarbage(string name, double weight, double volumePerKg, string type);

        string Status();
    }
}
