using FluentAssertions;
using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class ClasAxeTests
    {
        [Test]
        public void FirstTest()
        {
            Axe axe = new Axe(1, 1);
            Assert.AreEqual(1, axe.AttackPoints, "AttackPoints are wrong");
            Assert.AreEqual(1, axe.DurabilityPoints);
            axe.AttackPoints.Should().Be(1);
        }

        [Test]
        public void AttackTest()
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            Assert.AreEqual(1, axe.DurabilityPoints);
        }
    }
}
