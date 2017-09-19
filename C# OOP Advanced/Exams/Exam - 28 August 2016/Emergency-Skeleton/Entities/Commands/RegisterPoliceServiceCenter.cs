using System.Collections.Generic;
using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.Commands
{
    public class RegisterPoliceServiceCenter : BaseCommand
    {
        public RegisterPoliceServiceCenter(IList<string> arguments, IEmergencyManagementSystem emergencyManager) : base(arguments, emergencyManager)
        {
        }

        public override string Execute()
        {
            return this.EmergencyManager.RegisterPoliceServiceCenter(this.Arguments);
        }
    }
}
