using System;

namespace BarracksWars___A_New_Factory.Core.Commands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];

            this.Repository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }
    }
}
