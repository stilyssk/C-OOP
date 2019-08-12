using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                CheckStartCapitalLeter(value, "firstName");
                CheckLeastCountOfLeter(value, 4,"firstName");
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                CheckStartCapitalLeter(value, "lastName");
                CheckLeastCountOfLeter(value, 3, "lastName");
                lastName = value;
            }
        }

        private void CheckStartCapitalLeter(string name,string messageName)
        {
            if (!char.IsUpper(name[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {messageName}");
            }
        }

        private void CheckLeastCountOfLeter(string name, int count, string messageName)
        {
            if (name.Length<count)
            {
                throw new ArgumentException($"Expected length at least {count} symbols! Argument: {messageName}");
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"First Name: {FirstName}");
            result.AppendLine($"Last Name: {LastName}");
            return result.ToString().TrimEnd();
        }
    }
}
