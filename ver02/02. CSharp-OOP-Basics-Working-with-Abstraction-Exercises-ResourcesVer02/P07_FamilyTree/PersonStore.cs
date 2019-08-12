using System;
using System.Collections.Generic;
using System.Text;

namespace P07_FamilyTree
{
    public class PersonStore : IPersonStore
    {
        private string name;
        private string birthday;

        public PersonStore()
        {
            this.Name = string.Empty;
            this.Birthday = string.Empty;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public void AddDate(string inputStringDate)
        {
            this.birthday = inputStringDate;
        }

        public void AddName(string inputStringDate)
        {
            this.Name = inputStringDate;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}";
        }
    }
}
