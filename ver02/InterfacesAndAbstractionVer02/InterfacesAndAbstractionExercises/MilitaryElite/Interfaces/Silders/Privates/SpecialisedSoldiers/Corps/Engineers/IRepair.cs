using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Engineers
{
    public interface IRepair
    {
        string PartName { get; set; }
        int HoursWorked { get; set; }
    }
}
