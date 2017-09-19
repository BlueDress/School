using System.Collections.Generic;
using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.Commands
{
    public class EmergencyReport : BaseCommand
    {
        public EmergencyReport(IList<string> arguments, IEmergencyManagementSystem emergencyManager) : base(arguments, emergencyManager)
        {
        }

        public override string Execute()
        {
            return this.EmergencyManager.EmergencyReport(this.Arguments);
        }
    }
}
