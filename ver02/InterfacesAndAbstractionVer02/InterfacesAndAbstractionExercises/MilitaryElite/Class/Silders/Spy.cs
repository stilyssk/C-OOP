using MilitaryElite.Interfaces.Silders;
using System.Text;

namespace MilitaryElite.Class.Silders
{
    public class Spy : Soldier, ISpy
    {
        private int codeNumber;
        public Spy( string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get => codeNumber; set => codeNumber = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            result.AppendLine($"Code Number: {this.CodeNumber}");
        
   
            return result.ToString().TrimEnd();
        }
    }
}
