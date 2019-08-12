using MilitaryElite.Interfaces.Silders;
using MilitaryElite.Interfaces.Silders.Privates;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Class.Silders.Privates
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private HashSet<IPrivate> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            Privates = new HashSet<IPrivate>();

        }


        public HashSet<IPrivate> Privates { get => privates; set => privates = value; }

        public void AddPrivate(IPrivate newPrivate)
        {
            privates.Add(newPrivate);
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Privates:");
            foreach (var currentPrivate in Privates)
            {
                result.AppendLine("  "+currentPrivate.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
