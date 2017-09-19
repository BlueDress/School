using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Interfaces.Entities;
using Emergency_Skeleton.Interfaces.IO;
using System;
using System.Linq;
using System.Reflection;

namespace Emergency_Skeleton.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IEmergencyManagementSystem emergencyManager;

        public Engine(IReader reader, IWriter writer, IEmergencyManagementSystem emergencyManager)
        {
            this.reader = reader;
            this.writer = writer;
            this.emergencyManager = emergencyManager;
        }

        public void Run()
        {
            while (true)
            {
                var input = reader.ReadLine();

                if (input.Equals("EmergencyBreak"))
                {
                    break;
                }

                var arguments = input.Split('|').ToList();
                var commandName = arguments[0];
                arguments.RemoveAt(0);
                var commandType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(commandName));
                var constructors = commandType.GetConstructors();
                var command = (ICommand)constructors[0].Invoke(new object[] { arguments, this.emergencyManager });
                this.writer.WriteLine(command.Execute());
            }
        }
    }
}
