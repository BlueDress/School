using Hell.Interfaces.Entities;
using System.Collections.Generic;
using Hell.Interfaces.Core;

namespace Hell.Commands
{
    public abstract class AbstractCommand : ICommand
    {
        public AbstractCommand(IList<string> args, IManager manager)
        {
            this.Args = args;
            this.Manager = manager;
        }

        public IList<string> Args { get; }
        public IManager Manager { get; }

        public abstract string Execute();
    }
}
