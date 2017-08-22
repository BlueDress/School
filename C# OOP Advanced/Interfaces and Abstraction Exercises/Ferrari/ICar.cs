namespace Ferrari
{
    public interface ICar
    {
        string Model { get; }
        string DriverName { get; }

        string Brakes();
        string GasPedal();
    }
}
