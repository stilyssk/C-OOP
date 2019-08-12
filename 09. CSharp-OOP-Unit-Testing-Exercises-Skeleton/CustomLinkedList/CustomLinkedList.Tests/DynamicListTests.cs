using NUnit.Framework;
using System;

namespace CustomLinkedList.Tests
{
    [TestFixture]

    public class DynamicListTests
    {
        public object ListNode { get; private set; }

        [SetUp]
        public void SetUp()
        {

        }
        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void ConstructorIntPass()
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            Assert.AreEqual(0, dynamicList.Count);
        }

        [Test]
        public void ConstructorIntFalse()
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            Assert.AreNotEqual(1, dynamicList.Count);
        }

        [Test]
        public void AddPass()
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(10);
            Assert.AreEqual(1, dynamicList.Count);
        }

        [Test]
        public void AddFalse()
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(10);
            Assert.AreNotEqual(0, dynamicList.Count);
        }

        [Test]
        public void RemoveAtPass()
        {
            DynamicList<int> dynamicList = new DynamicList<int>();

            dynamicList.Add(10);
            dynamicList.Add(10);
            dynamicList.RemoveAt(1);

            Assert.AreEqual(1, dynamicList.Count);
        }

        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void RemoveAtArgumentOutOfRangeException(int value)
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(10);
            dynamicList.Add(20);
            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicList.RemoveAt(4));
        }

        [Test]
        public void RemoveAtNotPass()
        {
            DynamicList<int> dynamicList = new DynamicList<int>();

            dynamicList.Add(10);
            dynamicList.Add(10);
            dynamicList.RemoveAt(1);

            Assert.AreNotEqual(2, dynamicList.Count);
        }

        [Test]
        [TestCase(10)]

        public void RemovePass(int value)
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(10);
            Assert.AreEqual(0, dynamicList.Remove(value));
        }

        [Test]
        [TestCase(20)]
        [TestCase(30)]
        [TestCase(40)]
        public void RemoveNotPass(int value)
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(10);
            Assert.AreEqual(-1, dynamicList.Remove(value));
        }

        [Test]
        [TestCase(20)]
        [TestCase(30)]
        [TestCase(40)]
        public void IndexOfNotPass(int value)
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(10);
            Assert.AreEqual(-1, dynamicList.Remove(value));
        }

        [Test]
        [TestCase(10)]
        public void IndexOfPass(int value)
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(20);
            dynamicList.Add(10);
            Assert.AreEqual(1, dynamicList.Remove(value));
        }

        [Test]
        [TestCase(10)]
        public void ContainsPass(int value)
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(20);
            dynamicList.Add(10);
            Assert.AreEqual(true, dynamicList.Contains(value));
        }

        [Test]
        [TestCase(30)]
        public void ContainsNotPass(int value)
        {
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(20);
            dynamicList.Add(10);
            Assert.AreEqual(false, dynamicList.Contains(value));
        }


    }
}
