using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            var dummy = new Dummy(10, 10);

            dummy.TakeAttack(5);

            Assert.AreEqual(5, dummy.Health, "Dummy doesn't lose health after being attacked");
        }

        [Test]
        public void DeadDummyThrowsExceptionifattacked()
        {
            var dummy = new Dummy(1, 10);

            dummy.TakeAttack(1);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            var dummy = new Dummy(0, 10);

            dummy.GiveExperience();

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}
