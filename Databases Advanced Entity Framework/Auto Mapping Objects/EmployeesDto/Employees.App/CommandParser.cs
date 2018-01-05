using Employees.App.Commands;
using System;
using System.Linq;
using System.Reflection;

namespace Employees.App
{
    public class CommandParser
    {
        public ICommand Parse(IServiceProvider serviceProvider, string comandName)
        {
            var commandType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals($"{comandName}Command"));

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command name");
            }

            var constructor = commandType.GetConstructors().First();

            var constructorParams = constructor.GetParameters().Select(p => p.ParameterType);

            var constructorArgs = constructorParams.Select(serviceProvider.GetService).ToArray();

            var command = (ICommand)constructor.Invoke(constructorArgs);

            return command;
        }
    }
}
