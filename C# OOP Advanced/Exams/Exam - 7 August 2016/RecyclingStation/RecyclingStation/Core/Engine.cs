namespace RecyclingStation.Core
{
    using Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IRecyclingStation recyclingStation;
        private MethodInfo[] recyclingStationMethods;

        public Engine(IWriter writer, IReader reader, IRecyclingStation recyclingStation)
        {
            this.writer = writer;
            this.reader = reader;
            this.recyclingStation = recyclingStation;

            this.recyclingStationMethods = this.recyclingStation.GetType().GetMethods();
        }

        public void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine();

                if (input.Equals("TimeToRecycle"))
                {
                    break;
                }

                var commandArgs = input.Split();
                var methodName = commandArgs[0];
                var parameters = new string[0];

                if (commandArgs.Length > 1)
                {
                    parameters = commandArgs[1].Split('|');
                }

                var method = this.recyclingStationMethods.FirstOrDefault(m => m.Name.Equals(methodName));
                var methodParameters = method.GetParameters();

                var convertedParameters = new object[methodParameters.Length];

                for (int i = 0; i < methodParameters.Length; i++)
                {
                    var currentParameterType = methodParameters[i].ParameterType;
                    convertedParameters[i] = Convert.ChangeType(parameters[i], currentParameterType);
                }

                this.writer.WriteLine(method.Invoke(this.recyclingStation, convertedParameters).ToString());
            }
        }
    }
}
