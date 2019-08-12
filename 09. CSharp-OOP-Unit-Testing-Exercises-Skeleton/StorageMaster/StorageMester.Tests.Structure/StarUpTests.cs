using NUnit.Framework;
using StorageMaster.Core;
using StorageMaster.Core.IO;
using StorageMaster.Core.IO.Contracts;
using System;

namespace StorageMester1.Tests.Structure
{
    [TestFixture]
    public class StarUpTests 
    {

        [Test]
        public void StorageMasterConstructorPass()
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Engine engine = new Engine(reader, writer);
            StorageMaster.Core.StorageMaster storageMaster = new StorageMaster.Core.StorageMaster();
            string type = "car";
            double price = 1000;
            
            Assert.AreEqual($"Added {type} to pool", storageMaster.AddProduct(type, price));

        }

        //[Test]
        //public void StorageMasterConstructorPass()
        //{

        //    StorageMaster.Core.StorageMaster storageMaster = new StorageMaster.Core.StorageMaster();
        //    string type = "car";
        //    double price = 1000;

        //    Assert.AreEqual($"Added {type} to pool", storageMaster.AddProduct(type, price));

        //}
    }
}
