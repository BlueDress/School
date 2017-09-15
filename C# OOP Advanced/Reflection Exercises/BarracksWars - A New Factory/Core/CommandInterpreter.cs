using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace BarracksWars___A_New_Factory.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string commandFullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + "Command";

            var commandType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(commandFullName));

            object[] commandParams =
            {
                data,
                this.repository,
                this.unitFactory
            };

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            return (IExecutable)Activator.CreateInstance(commandType, commandParams);
        }
    }
}
