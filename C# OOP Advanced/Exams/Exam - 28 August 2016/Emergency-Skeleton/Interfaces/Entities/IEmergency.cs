namespace Emergency_Skeleton.Interfaces.Entities
{
    public interface IEmergency
    {
        int NumberOfCasualties { get; set; }
        int PropertyDamage { get; set; }
        string Status { get; set; }
    }
}
