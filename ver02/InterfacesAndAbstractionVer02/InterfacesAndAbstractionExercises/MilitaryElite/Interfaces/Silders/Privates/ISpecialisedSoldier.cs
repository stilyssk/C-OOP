using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders.Privates
{
    public interface ISpecialisedSoldier
    {
        SpecialisedSoldiers.ICorp Corp { get; set; }

        string ToString();
    }
}
