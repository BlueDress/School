using System.Collections.Generic;
using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.IO;
using SchoolManagementSystem.Common;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Commands
{
    public class AddStudentToSchoolGroupCommand : AbstractCommand
    {
        public AddStudentToSchoolGroupCommand(IList<string> args, IManager manager, ITextFormatter formatter) : base(args, manager, formatter)
        {
        }

        public override string Execute()
        {
            Student student = this.Manager.GetStudent(Args[0], Args[1]);
            SchoolGroup schoolGroup = this.Manager.GetSchoolGroup(Args[2]);

            this.Manager.AddStudentToSchoolGroup(schoolGroup, student);

            this.Formatter.ClearScreen();
            return $"{Args[0]} {Args[1]} {SuccessMessages.StudentAddedToSchoolGroupSuccessfully} {Args[2]}.";
        }
    }
}
