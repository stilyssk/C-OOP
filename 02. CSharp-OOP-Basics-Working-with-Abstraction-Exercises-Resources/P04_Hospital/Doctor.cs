using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Doctor
    {
        private string name;
        private List<string> patinent;
        
        public Doctor()
        {
            this.patinent = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string NewPatient
        {
            set
            {
                this.patinent.Add(value);
            }
        } 

        public void AddPatient(string newPatient)
        {
            this.patinent.Add(newPatient);
        }

        public List<string> PrintAllPatient()
        {
            return patinent;
        }
    }
}
