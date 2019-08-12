namespace Skeleton.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AxeTests
    {

        [Test]
        [TestCase(10,10)]
        [TestCase(20,20)]
        [TestCase(-20,-20)]
        public void CheckAttackPoints(int attack, int durability)
        {
            Axe axe = new Axe(attack, durability);
            Assert.AreEqual(attack, axe.AttackPoints,"Attack point are wrong");

        }
        [Test]
        [TestCase(10, 10)]
        [TestCase(20, 20)]
        [TestCase(-20, -20)]
        public void CheckDurabilityPoints(int attack, int durability)
        {
            Axe axe = new Axe(attack, durability);
            Assert.AreEqual(durability, axe.DurabilityPoints);
        }
        public delegate void testdd(Dummy dummy);
        [Test]
        [TestCase(10, 10)]
        [TestCase(20, 20)]
        [TestCase(-20, -20)]
        public void CheckAttack(int attack, int durability) { 

            Axe axe = new Axe(attack, durability);
            Dummy dummy = new Dummy(-10, -20);
            //axe.Attack(dummy);
            //Assert.Throws(typeof(InvalidOperationException),new TestDelegate(axe.Attack(new Dummy(10, 20))));
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
