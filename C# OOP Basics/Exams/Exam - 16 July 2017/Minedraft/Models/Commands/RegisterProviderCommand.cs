using Minedraft.Models.Contracts;
using Minedraft.Services.Contracts;
using System.Linq;

namespace Minedraft.Models.Commands
{
    public class RegisterProviderCommand : ICommand
    {
        private IDraftManager draftManager;

        public RegisterProviderCommand(IDraftManager draftManager)
        {
            this.draftManager = draftManager;
        }

        public string ExecuteCommand(params string[] commandArguments)
        {
            return this.draftManager.RegisterProvider(commandArguments.ToList());
        }
    }
}