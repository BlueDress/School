using NUnit.Framework;
using RecyclingStation.TypeOfGarbageDisposalStrategy;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;

namespace RecyclingStation.Tests
{
    [TestFixture]
    public class StrategyHolderTests
    {
        [Test]
        public void TestMethod()
        {
            var testStrategy = new BurnableGarbageDisposalStrategy();
            var type = typeof(DisposableAttribute);
            var strategies = new Dictionary<Type, IGarbageDisposalStrategy>();

            var strategyHolder = new StrategyHolder(strategies);
        }
    }
}
