
namespace CustomStack
{
    using System.Collections;
    using System.Collections.Generic;

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count==0)
            {
                return true;
            }
            return false;
        }

        public Stack<string> AddRange()
        {
            return this;
        }
    }
}
