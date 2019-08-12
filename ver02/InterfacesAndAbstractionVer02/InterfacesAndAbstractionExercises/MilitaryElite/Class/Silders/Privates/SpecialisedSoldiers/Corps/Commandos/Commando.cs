using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers;
using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Commandos;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;
        private ICorp corps;

        public Commando(string id,
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
            Missions = new List<IMission>();
        }

        public ICorp Corps { get => corps; set => corps = value; }
        public List<IMission> Missions { get => missions; set => missions = value; }

        public void AddMission(IMission newMission)
        {
            Missions.Add(newMission);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Missions:");
            foreach (var currentMission in Missions)
            {
                result.Append(currentMission.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
