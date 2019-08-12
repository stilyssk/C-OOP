using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders
{
    public interface ISpy:ISoldier
    {
        int CodeNumber { get; set; }

        string ToString();
    }
}
