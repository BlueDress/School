using System.Collections.Generic;
using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.IO;
using SchoolManagementSystem.Common;

namespace SchoolManagementSystem.Commands
{
    public class CreateStudentCommand : AbstractCommand
    {
        public CreateStudentCommand(IList<string> args, IManager manager, ITextFormatter formatter) : base(args, manager, formatter)
        {
        }

        public override string Execute()
        {
            this.Manager.CreateStudent(Args[0], Args[1]);

            this.Formatter.ClearScreen();
            return $"{Args[0]} {Args[1]} {SuccessMessages.TeacherOrStudentCreatedSuccessfully}";
        }
    }
}
