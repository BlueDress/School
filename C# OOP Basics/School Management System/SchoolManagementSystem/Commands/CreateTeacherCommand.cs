using System.Collections.Generic;
using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.IO;
using SchoolManagementSystem.Common;

namespace SchoolManagementSystem.Commands
{
    public class CreateTeacherCommand : AbstractCommand
    {
        public CreateTeacherCommand(IList<string> args, IManager manager, ITextFormatter formatter) : base(args, manager, formatter)
        {
        }

        public override string Execute()
        {
            this.Manager.CreateTeacher(Args[0], Args[1]);

            this.Formatter.ClearScreen();
            return $"{Args[0]} {Args[1]} {SuccessMessages.TeacherOrStudentCreatedSuccessfully}";
        }
    }
}
