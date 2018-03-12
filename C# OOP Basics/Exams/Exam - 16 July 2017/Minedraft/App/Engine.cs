using Minedraft.IO.Contracts;
using Minedraft.Models.Contracts;
using Minedraft.Services.Contracts;
using System.Linq;
using System.Reflection;

namespace Minedraft.App
{
    public class Engine
    {
        private const string shutdownCommand = "Shutdown";

        private IDraftManager draftManager;
        private IReader reader;
        private IWriter writer;

        public Engine(IDraftManager draftManager, IReader reader, IWriter writer)
        {
            this.draftManager = draftManager;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine().Split(new [] { " " }, System.StringSplitOptions.RemoveEmptyEntries);
                var commandName = input[0];
                var commandArguments = input.Skip(1).ToArray();

                var type = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name.Equals($"{commandName}Command")).First();
                var constructor = type.GetConstructors().First();
                var command = (ICommand)constructor.Invoke(new object[] { this.draftManager });

                this.writer.WriteLine(command.ExecuteCommand(commandArguments));

                if (commandName.Equals(shutdownCommand))
                {
                    break;
                }
            }
        }
    }
}
