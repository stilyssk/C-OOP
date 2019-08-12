using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace P04_Hospital
{
    public class Doctor : IDoctor
    {
        private string name;
        private List<string> listPatient;

        public Doctor(string name)
        {
            this.Name = name;
            this.ListPatient = new List<string>();
        }

        public string Name { get => this.name; set => this.name = value; }

        public List<string> ListPatient { get => this.listPatient; set => this.listPatient = value; }

        public void AddPatient(string name)
        {
            this.ListPatient.Add(name);
        }

        public List<string> OrderedListPatient()
        {
            return ListPatient.OrderBy(x => x).ToList();

        }

    }
}
