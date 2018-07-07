using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.Entities;
using SchoolManagementSystem.Contracts.IO;
using System.Collections.Generic;

namespace SchoolManagementSystem.Commands
{
    public abstract class AbstractCommand : ICommand
    {
        public AbstractCommand(IList<string> args, IManager manager, ITextFormatter formatter)
        {
            this.Args = args;
            this.Manager = manager;
            this.Formatter = formatter;
        }

        public IList<string> Args { get; }
        public IManager Manager { get; }
        public ITextFormatter Formatter { get; }

        public abstract string Execute();
    }
}
