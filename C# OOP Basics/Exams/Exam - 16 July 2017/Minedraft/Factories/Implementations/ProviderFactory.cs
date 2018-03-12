using Minedraft.Models.Providers;
using System.Collections.Generic;

namespace Minedraft.Factories.Implementations
{
    public static class ProviderFactory
    {
        private const string solarType = "Solar";

        public static Provider CreateProvider(IList<string> arguments)
        {
            var type = arguments[0];
            var id = arguments[1];
            var energyOutput = double.Parse(arguments[2]);

            if (type.Equals(solarType))
            {
                var solarProvider = new SolarProvider(id, energyOutput);

                return solarProvider;
            }
            else
            {
                var pressureProvider = new PressureProvider(id, energyOutput);

                return pressureProvider;
            }
        }
    }
}
