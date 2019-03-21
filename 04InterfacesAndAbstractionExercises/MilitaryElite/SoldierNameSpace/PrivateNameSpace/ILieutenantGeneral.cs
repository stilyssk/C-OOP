using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.SoldierNameSpace.PrivateNameSpace
{
    public interface ILieutenantGeneral:IPrivate
    {
        List<IPrivate> privatesUnderCommand { get; set; }
    }
}
