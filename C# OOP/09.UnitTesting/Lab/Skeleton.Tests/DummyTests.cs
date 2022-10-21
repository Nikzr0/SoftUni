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
            var dummy = new Dummy(12,67);
            dummy.TakeAttack(5);
            Assert.That(dummy.Health < 12);
        }

        [Test]
        public void DeadDummyThrowAnExceptionIfAttacked()
        {
            var dummy = new Dummy(0, 67);

            Assert.Throws<InvalidOperationException>(()=> dummy.TakeAttack(5));
        }

        [Test]
        public void DeadDummyCanGiveHP()
        {
            var dummy = new Dummy(3, 67);
            dummy.TakeAttack(5);

            Assert.That(dummy.IsDead);
        }

        [Test]
        public void DeadDummyCannotGiveHP()
        {
            var dummy = new Dummy(66, 67);

            Assert.Throws<InvalidOperationException>(()=> dummy.GiveExperience());
        }
    }
}