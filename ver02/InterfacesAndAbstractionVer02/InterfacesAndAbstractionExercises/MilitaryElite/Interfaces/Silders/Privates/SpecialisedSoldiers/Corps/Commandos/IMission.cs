using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Commandos
{
    public interface IMission
    {
        string CodeName { get; set; }
        string StateName { get; set; }
    }
}
