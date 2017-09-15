using System.Collections.Generic;
using Hell.Interfaces.Core;

namespace Hell.Commands
{
    public class ItemCommand : AbstractCommand
    {
        public ItemCommand(IList<string> args, IManager manager) : base(args, manager)
        {
        }

        public override string Execute()
        {
            return this.Manager.AddItemToHero(this.Args);
        }
    }
}
