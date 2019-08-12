using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Engineers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers
{
    public interface IEngineer:ISoldier
    {
        HashSet<IRepair> Repairs { get; set; }
        ICorp Corps { get; set; }
        void AddRepairs(IRepair newRepair);
        string ToString();
    }
}
