using System;
using System.Collections.Generic;
using System.Text;

namespace P07_FamilyTree
{
    public class ParentChildPair : IParentChildPair
    {
        private IPersonStore parent;
        private IPersonStore child;

        public ParentChildPair()
        {
            Parent = new PersonStore();
            Child = new PersonStore();
        }

        public IPersonStore Parent { get => parent; set => parent = value; }
        public IPersonStore Child { get => child; set => child = value; }
    }
}
