using System.Collections.Generic;
using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.IO;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Common;

namespace SchoolManagementSystem.Commands
{
    public class AddSchoolGroupToTeacherCommand : AbstractCommand
    {
        public AddSchoolGroupToTeacherCommand(IList<string> args, IManager manager, ITextFormatter formatter) : base(args, manager, formatter)
        {
        }

        public override string Execute()
        {
            Teacher teacher = this.Manager.GetTeacher(Args[0], Args[1]);
            SchoolGroup schoolGroup = this.Manager.GetSchoolGroup(Args[2]);

            this.Manager.AddSchoolGroupToTeacher(schoolGroup, teacher);

            this.Formatter.ClearScreen();
            return $"{Args[2]} {SuccessMessages.SchoolGroupAddedToTeacherSuccessfully} {Args[0]} {Args[1]}.";
        }
    }
}
