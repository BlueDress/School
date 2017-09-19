using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Interfaces.Entities;
using System.Collections.Generic;

namespace Emergency_Skeleton.Models
{
    public abstract class BaseCommand : ICommand
    {
        private IList<string> arguments;
        private IEmergencyManagementSystem emergencyManager;

        public BaseCommand(IList<string> arguments, IEmergencyManagementSystem emergencyManager)
        {
            this.arguments = arguments;
            this.emergencyManager = emergencyManager;
        }

        public IList<string> Arguments
        {
            get
            {
                return this.arguments;
            }
        }

        public IEmergencyManagementSystem EmergencyManager
        {
            get
            {
                return this.emergencyManager;
            }
        }

        public abstract string Execute();
    }
}
