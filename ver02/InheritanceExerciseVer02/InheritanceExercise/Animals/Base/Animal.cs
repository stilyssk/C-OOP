using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Base
{
    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        private string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    ExeptionMessage();
                }
                name = value;
            }
        }
        private int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    ExeptionMessage();
                }
                age = value;
            }
        }
        private string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    ExeptionMessage();

                }
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    ExeptionMessage();
                }
                gender = value;
            }
        }

        private void ExeptionMessage()
        {
            throw new ArgumentException("Invalid input!");
        }
        public virtual string ProduceSound()
        {
            return "";
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{GetType().Name}");
            result.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            result.AppendLine(ProduceSound());

            return result.ToString().TrimEnd();
        }
    }
}
