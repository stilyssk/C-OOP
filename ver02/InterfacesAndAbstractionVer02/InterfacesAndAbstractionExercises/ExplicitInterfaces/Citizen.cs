using ExplicitInterfaces.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        private string name;
        public Citizen(string inputName)
        {
            this.name = inputName;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string country
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
        string IPerson.GetName()
        {
            return $"{this.Name}";
        }
    }
}
