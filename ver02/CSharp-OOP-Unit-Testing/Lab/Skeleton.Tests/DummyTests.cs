using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Tests
{
    [TestFixture]
    class DummyTests
    {
 
        [Test]
        public void HealthGetTest()
        {
            Dummy dummy = new Dummy(10, 11);
            Assert.AreEqual(dummy.Health, 10);
        }
        [Test]
        public void TakeAttackTest()
        {
            Dummy dummy = new Dummy(-10, 11);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(11));
        }
        [Test]
        public void GiveExperienceTest()
        {
            Dummy dummy = new Dummy(10, 11);
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
        [Test]
        public void IsDeadTrueTest()
        {
            Dummy dummy = new Dummy(-10, 11);
            Assert.IsTrue(dummy.IsDead());
        }
        [Test]
        public void IsDeadFalseTest()
        {
            Dummy dummy = new Dummy(10, 11);
            Assert.IsFalse(dummy.IsDead());
        }
    }
}
