using Minedraft.Models.Contracts;
using Minedraft.Services.Contracts;

namespace Minedraft.Models.Commands
{
    public class DayCommand : ICommand
    {
        private IDraftManager draftManager;

        public DayCommand(IDraftManager draftManager)
        {
            this.draftManager = draftManager;
        }

        public string ExecuteCommand(params string[] commandArguments)
        {
            return this.draftManager.Day();
        }
    }
}