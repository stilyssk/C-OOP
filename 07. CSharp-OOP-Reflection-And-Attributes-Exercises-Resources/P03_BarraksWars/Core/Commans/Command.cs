using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03BarracksFactory.Core.Commans
{
    public abstract class Command : IExecutable
    {

        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected IRepository Repository { get => repository; set => repository = value; }
        protected IUnitFactory UnitFactory { get => unitFactory; set => unitFactory = value; }

        protected string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public abstract string Execute();
    }
}
