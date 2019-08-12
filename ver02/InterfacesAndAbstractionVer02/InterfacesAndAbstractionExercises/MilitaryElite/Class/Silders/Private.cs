using MilitaryElite.Interfaces.Silders;
using System;
using System.Text;

namespace MilitaryElite.Class.Silders
{
    public class Private : Soldier,IPrivate
    {
        private decimal salary;
        public Private(string id, string firstName, string lastName,decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {Math.Round(this.Salary,2):f2}");
            return result.ToString().TrimEnd();
        }
    }
}
