using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Silders.Privates
{
    public interface ILieutenantGeneral:IPrivate
    {
        HashSet<IPrivate> Privates { get; set; }

        void AddPrivate(IPrivate newPrivate);
    }
}
