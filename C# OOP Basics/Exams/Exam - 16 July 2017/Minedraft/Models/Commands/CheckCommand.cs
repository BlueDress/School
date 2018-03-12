using Minedraft.Models.Contracts;
using Minedraft.Services.Contracts;
using System.Linq;

namespace Minedraft.Models.Commands
{
    public class CheckCommand : ICommand
    {
        private IDraftManager draftManager;

        public CheckCommand(IDraftManager draftManager)
        {
            this.draftManager = draftManager;
        }

        public string ExecuteCommand(params string[] commandArguments)
        {
            return this.draftManager.Check(commandArguments.ToList());
        }
    }
}