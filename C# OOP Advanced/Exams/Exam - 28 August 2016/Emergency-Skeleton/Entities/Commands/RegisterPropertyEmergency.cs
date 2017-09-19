using System.Collections.Generic;
using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.Commands
{
    public class RegisterPropertyEmergency : BaseCommand
    {
        public RegisterPropertyEmergency(IList<string> arguments, IEmergencyManagementSystem emergencyManager) : base(arguments, emergencyManager)
        {
        }

        public override string Execute()
        {
            return this.EmergencyManager.RegisterPropertyEmergency(this.Arguments);
        }
    }
}
