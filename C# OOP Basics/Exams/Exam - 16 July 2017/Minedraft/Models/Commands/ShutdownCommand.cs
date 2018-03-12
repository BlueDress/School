using Minedraft.Models.Contracts;
using Minedraft.Services.Contracts;

namespace Minedraft.Models.Commands
{
    public class ShutdownCommand : ICommand
    {
        private IDraftManager draftManager;

        public ShutdownCommand(IDraftManager draftManager)
        {
            this.draftManager = draftManager;
        }

        public string ExecuteCommand(params string[] commandArguments)
        {
            return this.draftManager.ShutDown();
        }
    }
}