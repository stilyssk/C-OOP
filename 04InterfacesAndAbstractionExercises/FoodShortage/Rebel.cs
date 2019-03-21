using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
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

        public int Age
        {
            get => this.age;
            set
            {
                this.age = value;
            }
        }

        public string Group
        {
            get => this.group;
            set
            {
                this.group = value;
            }
        }

        public int Food { get => this.food; set { this.food = value; } }

        public int BuyFood()
        {
            return 5;
        }
    }
}
