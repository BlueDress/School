using Minedraft.Models.Contracts;
using Minedraft.Services.Contracts;
using System.Linq;

namespace Minedraft.Models.Commands
{
    public class RegisterHarvesterCommand : ICommand
    {
        private IDraftManager draftManager;

        public RegisterHarvesterCommand(IDraftManager draftManager)
        {
            this.draftManager = draftManager;
        }

        public string ExecuteCommand(params string[] commandArguments)
        {
           return this.draftManager.RegisterHarvester(commandArguments.ToList());
        }
    }
}
