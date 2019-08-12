using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers;
using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Engineers;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers
{
    public class Engineer :SpecialisedSoldier, IEngineer
    {
        private HashSet<IRepair> repairs;
        private ICorp corps;


        public Engineer(string id,
                        string firstName,
                        string lastName,
                        decimal salary,
                        ICorp corps) : base(id,
                                                      firstName,
                                                      lastName,
                                                      salary,
                                                      corps)
        {
            Corps = corps;
            Repairs = new HashSet<IRepair>();
        }
        public ICorp Corps { get => corps; set => corps = value; }

        public HashSet<IRepair> Repairs
        {
            get => repairs;
            set
            {
                repairs = value;
            }
        }

        public void AddRepairs(IRepair newRepair)
        {
            Repairs.Add(newRepair);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Repairs:");
            foreach (var currentRepair in Repairs)
            {
                result.Append(currentRepair.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
