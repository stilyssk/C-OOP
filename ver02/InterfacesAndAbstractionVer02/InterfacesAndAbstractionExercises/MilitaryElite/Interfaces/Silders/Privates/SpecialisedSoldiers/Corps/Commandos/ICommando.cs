using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Commandos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers
{
    public interface ICommando:ISoldier
    {
        List<IMission> Missions { get; set; }
        ICorp Corps { get; set; }

        void AddMission(IMission newMission);
        string ToString();
    }
}
