using Minedraft.Models.Contracts;
using Minedraft.Services.Contracts;
using System.Linq;

namespace Minedraft.Models.Commands
{
    public class ModeCommand : ICommand
    {
        private IDraftManager draftManager;

        public ModeCommand(IDraftManager draftManager)
        {
            this.draftManager = draftManager;
        }

        public string ExecuteCommand(params string[] commandArguments)
        {
            return this.draftManager.Mode(commandArguments.ToList());
        }
    }
}