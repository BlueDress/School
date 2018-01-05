namespace Employees.App.Commands
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
