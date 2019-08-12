using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : AddRemoveClass, IUsed
    {
        public override int Add(string item)
        {
            InternalList.Insert(0, item);
            return 0;
        }
        public override string Remove()
        {
            var index = 0;
            var removeElement = InternalList[index];
            InternalList.RemoveAt(index);
            return removeElement;
        }

        public int Used(string item)
        {
            return InternalList.Count;
        }
    }
}
