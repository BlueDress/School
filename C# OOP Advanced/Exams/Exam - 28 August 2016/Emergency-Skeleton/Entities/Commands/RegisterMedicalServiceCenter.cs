﻿using System.Collections.Generic;
using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.Commands
{
    public class RegisterMedicalServiceCenter : BaseCommand
    {
        public RegisterMedicalServiceCenter(IList<string> arguments, IEmergencyManagementSystem emergencyManager) : base(arguments, emergencyManager)
        {
        }

        public override string Execute()
        {
            return this.EmergencyManager.RegisterMedicalServiceCenter(this.Arguments);
        }
    }
}
