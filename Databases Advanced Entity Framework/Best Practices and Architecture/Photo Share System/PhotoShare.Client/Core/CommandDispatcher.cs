namespace PhotoShare.Client.Core
{
    using PhotoShare.Client.Core.Commands;
    using PhotoShare.Data;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandDispatcher
    {
        public PhotoShareContext context;

        public CommandDispatcher(PhotoShareContext context)
        {
            this.context = context;
        }

        public string DispatchCommand(string[] commandParameters)
        {
            var commandName = commandParameters[0];
            var commandArgs = commandParameters.Skip(1).ToArray();

            var commandType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(c => c.Name.Equals($"{commandName}Command"));

            var constructors = commandType.GetConstructors();
            
            var command = (ICommand)constructors[0].Invoke(new object[] { this.context });

            if (command == null)
            {
                throw new InvalidOperationException($"Command {commandName} not valid!");
            }
            
            return command.Execute(commandArgs);
        }
    }
}
