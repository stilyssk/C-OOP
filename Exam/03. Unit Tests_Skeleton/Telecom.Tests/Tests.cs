namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        string make;
        string model;
        Phone phone;
        [SetUp]
        public void SetUp()
        {
            make = "Test Make";
            model = "Test Model";
            phone = new Phone(make, model);
        }
        [Test]
        public void ConstructorSetMakePropertyCorectly()
        {

            Assert.AreEqual(make, phone.Make);
        }
        [Test]
        public void ConstructorSetModelPropertyCorectly()
        {

            Assert.AreEqual(model, phone.Model);
        }
        [Test]
        public void ConstructorSetPhonebookFieldCorectly()
        {

            Assert.AreEqual(0, phone.Count);
        }
        [Test]
        public void SetGetMakePropertyCorrectly()
        {

            var getMakeValue = phone.Make;
            Assert.AreEqual(make, getMakeValue);

        }

        [Test]
        public void SetMakeThrowArgumentExeption()
        {
            make = "";
            Assert.Throws<ArgumentException>(() => new Phone(make, model));
        }
        [Test]
        public void SetGetModelPropertyCorrectly()
        {

            var getModelValue = phone.Model;
            Assert.AreEqual(model, getModelValue);

        }

        [Test]
        public void AddContactThrowArgumentExeption()
        {
            phone.AddContact(make, model);
            Assert.Throws<InvalidOperationException>(() => phone.AddContact(make, model));
        }
        [Test]
        public void AddContactCorectly()
        {
            phone.AddContact(make, model);
            Assert.IsTrue($"Calling {make} - {model}..."==phone.Call(make));
        }
        [Test]
        public void CallCorectly()
        {
            phone.AddContact(make, model);
            var result = phone.Call(make);
            var expect = $"Calling {make} - {model}...";
            Assert.IsTrue(expect == result);
        }
        [Test]
        public void CllContactThrowArgumentExeption()
        {
            phone.AddContact(make, model);
            Assert.Throws<InvalidOperationException>(() => phone.Call( model));
        }
    }
}