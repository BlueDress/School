namespace RecyclingStation.Factories
{
    using System;
    using RecyclingStation.Contracts;
    using WasteDisposal.Interfaces;
    using System.Reflection;
    using System.Linq;

    public class WasteFactory : IWasteFactory
    {
        public IWaste GetWaste(string name, double weight, double volumePerKg, string type)
        {
            var typeOfWaste = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(type));
            
            return (IWaste)Activator.CreateInstance(typeOfWaste, new object[] { name, weight, volumePerKg });
        }
    }
}
