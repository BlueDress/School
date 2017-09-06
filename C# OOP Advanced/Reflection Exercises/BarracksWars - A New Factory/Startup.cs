using BarracksWars___A_New_Factory.Core;
using BarracksWars___A_New_Factory.Core.Factories;
using BarracksWars___A_New_Factory.Data;

namespace BarracksWars___A_New_Factory
{
    public class Startup
    {
        public static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            ICommandInterpreter commandInterpreter = new CommandInterpreter(repository, unitFactory);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
