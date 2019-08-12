using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; set; }

        string ToString();
    }


}
