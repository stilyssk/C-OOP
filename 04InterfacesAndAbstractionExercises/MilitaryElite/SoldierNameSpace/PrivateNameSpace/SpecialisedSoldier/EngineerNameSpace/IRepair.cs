using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.SoldierNameSpace.PrivateNameSpace.SpecialisedSoldier.EngineerNameSpace
{
    public interface IRepair
    {
        string PartName { get; set; }
        int HoursWorked { get; set; }
    }
}
