namespace Minedraft.Models.Contracts
{
    public interface ICommand
    {
        string ExecuteCommand(params string[] commandArguments);
    }
}
