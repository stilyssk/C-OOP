﻿namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        private int age;
        private string name;

        public Person(string name, int age)
        {
            this.Name = name;

            this.Age = age;
        }

        public virtual int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                this.age = value;
            }
        }
        public virtual string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Format($"Name: {this.Name}, Age: {this.Age}"));

            return stringBuilder.ToString();
        }
    }
}
