using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : AddRemoveClass
    {
        public override int Add(string item)
        {
            InternalList.Insert(0, item);
            return 0;
        }
    }
}
