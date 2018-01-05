using System;
using System.Linq;

namespace Employees.App
{
    public class Engine
    {
        private IServiceProvider serviceProvider;
        private CommandParser commandParser;

        public Engine(IServiceProvider serviceProvider, CommandParser commandParser)
        {
            this.serviceProvider = serviceProvider;
            this.commandParser = commandParser;
        }

        public void Run()
        {
            while (true)
            {
                var commands = Console.ReadLine().Split();

                var commandName = commands[0];
                var args = commands.Skip(1).ToArray();

                var command = this.commandParser.Parse(this.serviceProvider, commandName);

                var result = command.Execute(args);

                Console.WriteLine(result);
            }
        }
    }
}
