using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            var axe = new Axe(10, 10);
            var dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }

        [Test]
        public void AttackWithBrokenAxe()
        {
            var axe = new Axe(10, 1);
            var dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
