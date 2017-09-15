namespace RecyclingStation.Contracts
{
    public interface IWriter
    {
        void WriteLine();
        void WriteLine(string args);
        void Write(string args);
    }
}
