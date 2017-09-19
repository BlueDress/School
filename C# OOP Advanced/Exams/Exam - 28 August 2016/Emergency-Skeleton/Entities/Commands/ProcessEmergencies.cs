using System.Collections.Generic;
using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.Commands
{
    public class ProcessEmergencies : BaseCommand
    {
        public ProcessEmergencies(IList<string> arguments, IEmergencyManagementSystem emergencyManager) : base(arguments, emergencyManager)
        {
        }

        public override string Execute()
        {
            return this.EmergencyManager.ProcessEmergencies(this.Arguments);
        }
    }
}
