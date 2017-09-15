namespace RecyclingStation.WasteDisposal
{
    using System;
    using System.Linq;
    using RecyclingStation.WasteDisposal.Attributes;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class GarbageProcessor : IGarbageProcessor
    {
        public GarbageProcessor(IStrategyHolder strategyHolder)
        {
            this.StrategyHolder = strategyHolder;
        }

        public IStrategyHolder StrategyHolder { get; private set; }

        public IProcessingData ProcessWaste(IWaste garbage)
        {
            Type type = garbage.GetType();
            DisposableAttribute disposalAttribute = (DisposableAttribute)type.GetCustomAttributes(true).FirstOrDefault(x => x.GetType().Name.Equals(type.Name + "Attribute"));

            if (disposalAttribute == null)
            {
                throw new ArgumentException("The passed in garbage does not implement a supported Disposable Strategy Attribute.");
            }

            if (!this.StrategyHolder.GetDisposalStrategies.ContainsKey(disposalAttribute.GetType()))
            {
                var strategy = (IGarbageDisposalStrategy)Activator.CreateInstance(disposalAttribute.ConnectingAttribute);

                this.StrategyHolder.AddStrategy(disposalAttribute.GetType(), strategy);
            }

            var currentStrategy = this.StrategyHolder.GetDisposalStrategies[disposalAttribute.GetType()];

            return currentStrategy.ProcessGarbage(garbage);
        }
    }
}
