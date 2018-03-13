using GrandPrix.Models.Tyres;

namespace GrandPrix.Models.Contracts
{
    public interface ICar
    {
        int Hp { get; }
        double FuelAmount { get; set; }
        Tyre Tyre { get; set; }
    }
}
