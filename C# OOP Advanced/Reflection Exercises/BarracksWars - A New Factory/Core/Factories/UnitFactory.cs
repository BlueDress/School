namespace BarracksWars___A_New_Factory.Core.Factories
{
    using System;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var unitTypeName = Type.GetType("BarracksWars___A_New_Factory.Models.Units." + unitType);
            var unitInst = (IUnit)Activator.CreateInstance(unitTypeName);
            return unitInst;
        }
    }
}
