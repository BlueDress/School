namespace RecyclingStation
{
    using Core;
    using Factories;
    using IO;
    using System;
    using System.Collections.Generic;
    using WasteDisposal;
    using WasteDisposal.Interfaces;

    public class RecyclingStationMain
    {
        public static void Main()
        {
            var writer = new ConsoleWriter();
            var reader = new ConsoleReader();

            var strategies = new Dictionary<Type, IGarbageDisposalStrategy>();

            var strategyHolder = new StrategyHolder(strategies);

            var garbageProcessor = new GarbageProcessor(strategyHolder);
            var wasteFactory = new WasteFactory();

            var recyclingManager = new RecyclingManager(garbageProcessor, wasteFactory);

            var engine = new Engine(writer, reader, recyclingManager);
            engine.Run();
        }
    }
}
