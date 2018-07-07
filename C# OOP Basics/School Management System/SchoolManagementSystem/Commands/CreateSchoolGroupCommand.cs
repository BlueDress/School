using System.Collections.Generic;
using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.IO;
using SchoolManagementSystem.Common;

namespace SchoolManagementSystem.Commands
{
    public class CreateSchoolGroupCommand : AbstractCommand
    {
        public CreateSchoolGroupCommand(IList<string> args, IManager manager, ITextFormatter formatter) : base(args, manager, formatter)
        {
        }

        public override string Execute()
        {
            this.Manager.CreateSchoolGroup(Args[0]);

            this.Formatter.ClearScreen();
            return $"{Args[0]} {SuccessMessages.SchoolGroupCreatedSuccessfully}";
        }
    }
}
