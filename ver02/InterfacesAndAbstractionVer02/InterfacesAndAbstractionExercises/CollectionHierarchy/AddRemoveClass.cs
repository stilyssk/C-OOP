using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveClass : AddClass, IRemove
    {
        public virtual string Remove()
        {
            var index = InternalList.Count - 1;
            var removeElement = InternalList[index];
            InternalList.RemoveAt(index);
            return removeElement;
        }
    }
}
