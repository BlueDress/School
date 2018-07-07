using System.Collections.Generic;
using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.IO;

namespace SchoolManagementSystem.Commands
{
    public class PrintTeacherInfoCommand : AbstractCommand
    {
        public PrintTeacherInfoCommand(IList<string> args, IManager manager, ITextFormatter formatter) : base(args, manager, formatter)
        {
        }

        public override string Execute()
        {
            this.Formatter.ClearScreen();
            return this.Manager.GetTeacherInfo(Args[0], Args[1]);
        }
    }
}
