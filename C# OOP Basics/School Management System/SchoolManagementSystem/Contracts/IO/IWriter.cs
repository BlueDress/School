namespace SchoolManagementSystem.Contracts.IO
{
    public interface IWriter
    {
        void WriteLine();

        void WriteLine(string line);

        void Write(string line);
    }
}
