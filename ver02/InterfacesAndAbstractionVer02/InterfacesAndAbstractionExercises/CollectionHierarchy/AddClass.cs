using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddClass : IAdd
    {
        private List<string> internalList;

        public AddClass()
        {
            internalList = new List<string>();
        }

        public List<string> InternalList { get => internalList; set => internalList = value; }

        public virtual int Add(string item)
        {
            InternalList.Add(item);
            return InternalList.Count - 1;
        }
    }
}
