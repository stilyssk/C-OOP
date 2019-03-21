using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.SoldierNameSpace
{
    using PrivateNameSpace;

    public class Soldier : ILieutenantGeneral, IPrivate
    {
        public List<IPrivate> privatesUnderCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
