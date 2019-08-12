using MilitaryElite.Interfaces.Silders.Privates;
using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers;
using System.Text;

namespace MilitaryElite.Class.Silders.Privates
{
    public class SpecialisedSoldier:Private, ISpecialisedSoldier
    {

        private ICorp corp;
        public SpecialisedSoldier(string id,
                                  string firstName,
                                  string lastName,
                                  decimal salary,
                                  ICorp corps) : base(id,
                                                      firstName,
                                                      lastName,
                                                      salary)
        {
            corp = corps;
        }

        public ICorp Corp { get => corp; set => corp = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($"Corps: {Corp.CorpName}");

            return result.ToString().TrimEnd();
        }
    }
}
