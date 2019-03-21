using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.SoldierNameSpace.PrivateNameSpace.SpecialisedSoldier.EngineerNameSpace
{
    public interface IEngineer:IRepair
    {
        List<IRepair> Repairs { get; set; }
    }
}
